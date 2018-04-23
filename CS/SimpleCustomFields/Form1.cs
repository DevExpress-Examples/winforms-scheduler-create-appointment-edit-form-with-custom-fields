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
            MyAppointmentForm myForm = new MyAppointmentForm(this.schedulerControl1, e.Appointment);
            // Required for skin support
            myForm.LookAndFeel.ParentLookAndFeel = schedulerControl1.LookAndFeel;
            e.DialogResult = myForm.ShowDialog();
            e.Handled = true;
        }
        #endregion #EditAppointmentFormShowing

        #region #InitNewAppointment
        private void schedulerControl1_InitNewAppointment(object sender, DevExpress.XtraScheduler.AppointmentEventArgs e)
        {
            e.Appointment.Description += "Created at runtime at " + String.Format("{0:g}", DateTime.Now);
            e.Appointment.CustomFields["Price"] = 00.01d;
            e.Appointment.CustomFields["ContactInfo"] = "someone@somecompany.com";
        }
        #endregion #InitNewAppointment

        private void schedulerStorage1_AppointmentInserting(object sender, PersistentObjectCancelEventArgs e)
        {
            Appointment apt = ((Appointment)e.Object);
            apt.Description += "\r\nInserting at " + String.Format("{0:g}", DateTime.Now);
            apt.Description += "\r\n Price: " + apt.CustomFields["Price"];
        }

        private void schedulerStorage1_AppointmentChanging(object sender, PersistentObjectCancelEventArgs e)
        {
            Appointment apt = ((Appointment)e.Object);
            apt.Description += "\r\nChanging at " + String.Format("{0:g}", DateTime.Now);
            apt.Description += "\r\n Price: " + apt.CustomFields["Price"];
        }  
    }
}