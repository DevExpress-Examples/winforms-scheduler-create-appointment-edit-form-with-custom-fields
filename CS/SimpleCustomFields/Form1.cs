using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
#region #usings
using DevExpress.XtraScheduler;
#endregion #usings

namespace SimpleCustomFields
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            schedulerDataStorage1.AppointmentInserting += SchedulerStorage1_AppointmentInserting;
            schedulerDataStorage1.AppointmentsInserted += new PersistentObjectsEventHandler(this.OnApptChangedInsertedDeleted);
            schedulerDataStorage1.AppointmentChanging += SchedulerStorage1_AppointmentChanging;
            schedulerDataStorage1.AppointmentsChanged += new PersistentObjectsEventHandler(this.OnApptChangedInsertedDeleted);
            schedulerDataStorage1.AppointmentsDeleted += new PersistentObjectsEventHandler(this.OnApptChangedInsertedDeleted);

            this.schedulerControl1.Start = new DateTime(2010, 07, 01);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carsDBDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.carsDBDataSet.Cars);
            // TODO: This line of code loads data into the 'carsDBDataSet.CarScheduling' table. You can move, or remove it, as needed.
            this.carSchedulingTableAdapter.Fill(this.carsDBDataSet.CarScheduling);
            carSchedulingTableAdapter.Adapter.RowUpdated += new OleDbRowUpdatedEventHandler(carSchedulingTableAdapter_RowUpdated);

        }

        private void OnApptChangedInsertedDeleted(object sender, PersistentObjectsEventArgs e)
        {
            carSchedulingTableAdapter.Update(carsDBDataSet);
            carsDBDataSet.AcceptChanges();
        }

        private void carSchedulingTableAdapter_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            if (e.Status == UpdateStatus.Continue && e.StatementType == StatementType.Insert)
            {
                int id = 0;
                using (OleDbCommand cmd = new OleDbCommand("SELECT @@IDENTITY",
                    carSchedulingTableAdapter.Connection))
                {
                    id = (int)cmd.ExecuteScalar();
                }
                e.Row["ID"] = id;
            }
        }
        #region #EditAppointmentFormShowing
        private void schedulerControl1_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            MyAppointmentForm form = new MyAppointmentForm(sender as SchedulerControl, e.Appointment, e.OpenRecurrenceForm);
            try
            {
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
            }
            finally
            {
                form.Dispose();
            }
        }
        #endregion #EditAppointmentFormShowing

        #region #InitNewAppointment
        private void schedulerControl1_InitNewAppointment(object sender, DevExpress.XtraScheduler.AppointmentEventArgs e)
        {
            e.Appointment.Description += "Created at runtime at " + String.Format("{0:g}", DateTime.Now);
            e.Appointment.CustomFields["Amount"] = 00.01d;
            e.Appointment.CustomFields["ContactInfo"] = "someone@somecompany.com";
        }
        #endregion #InitNewAppointment
        #region #AppointmentInserting
        private void SchedulerStorage1_AppointmentInserting(object sender, PersistentObjectCancelEventArgs e) {
            if (((Appointment)e.Object).Start < DateTime.Now) e.Cancel = true;
        }
        #endregion #AppointmentInserting
        #region #AppointmentChanging
        private void SchedulerStorage1_AppointmentChanging(object sender, PersistentObjectCancelEventArgs e) {
            object busyKey = schedulerDataStorage1.Appointments.Statuses.GetByType(AppointmentStatusType.Busy).Id;
            if (((Appointment)e.Object).StatusKey == busyKey) e.Cancel = true;
        }
        #endregion #AppointmentChanging
    }
}