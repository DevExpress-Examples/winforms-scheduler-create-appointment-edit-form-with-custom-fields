Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data.OleDb
'#Region "#usings"
Imports DevExpress.XtraScheduler

'#End Region  ' #usings
Namespace SimpleCustomFields

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            AddHandler schedulerStorage1.AppointmentInserting, AddressOf SchedulerStorage1_AppointmentInserting
            AddHandler schedulerStorage1.AppointmentsInserted, New PersistentObjectsEventHandler(AddressOf OnApptChangedInsertedDeleted)
            AddHandler schedulerStorage1.AppointmentChanging, AddressOf SchedulerStorage1_AppointmentChanging
            AddHandler schedulerStorage1.AppointmentsChanged, New PersistentObjectsEventHandler(AddressOf OnApptChangedInsertedDeleted)
            AddHandler schedulerStorage1.AppointmentsDeleted, New PersistentObjectsEventHandler(AddressOf OnApptChangedInsertedDeleted)
            schedulerControl1.Start = New DateTime(2010, 07, 01)
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' TODO: This line of code loads data into the 'carsDBDataSet.Cars' table. You can move, or remove it, as needed.
            carsTableAdapter.Fill(carsDBDataSet.Cars)
            ' TODO: This line of code loads data into the 'carsDBDataSet.CarScheduling' table. You can move, or remove it, as needed.
            carSchedulingTableAdapter.Fill(carsDBDataSet.CarScheduling)
            AddHandler carSchedulingTableAdapter.Adapter.RowUpdated, New OleDbRowUpdatedEventHandler(AddressOf carSchedulingTableAdapter_RowUpdated)
        End Sub

        Private Sub OnApptChangedInsertedDeleted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
            carSchedulingTableAdapter.Update(carsDBDataSet)
            carsDBDataSet.AcceptChanges()
        End Sub

        Private Sub carSchedulingTableAdapter_RowUpdated(ByVal sender As Object, ByVal e As OleDbRowUpdatedEventArgs)
            If e.Status = UpdateStatus.Continue AndAlso e.StatementType = StatementType.Insert Then
                Dim id As Integer = 0
                Using cmd As OleDbCommand = New OleDbCommand("SELECT @@IDENTITY", carSchedulingTableAdapter.Connection)
                    id = CInt(cmd.ExecuteScalar())
                End Using

                e.Row("ID") = id
            End If
        End Sub

'#Region "#EditAppointmentFormShowing"
        Private Sub schedulerControl1_EditAppointmentFormShowing(ByVal sender As Object, ByVal e As AppointmentFormEventArgs)
            Dim form As MyAppointmentForm = New MyAppointmentForm(TryCast(sender, SchedulerControl), e.Appointment, e.OpenRecurrenceForm)
            Try
                e.DialogResult = form.ShowDialog()
                e.Handled = True
            Finally
                form.Dispose()
            End Try
        End Sub

'#End Region  ' #EditAppointmentFormShowing
'#Region "#InitNewAppointment"
        Private Sub schedulerControl1_InitNewAppointment(ByVal sender As Object, ByVal e As AppointmentEventArgs)
            e.Appointment.Description += "Created at runtime at " & String.Format("{0:g}", Date.Now)
            e.Appointment.CustomFields("Amount") = 00.01R
            e.Appointment.CustomFields("ContactInfo") = "someone@somecompany.com"
        End Sub

'#End Region  ' #InitNewAppointment
'#Region "#AppointmentInserting"
        Private Sub SchedulerStorage1_AppointmentInserting(ByVal sender As Object, ByVal e As PersistentObjectCancelEventArgs)
            If CType(e.Object, Appointment).Start < Date.Now Then e.Cancel = True
        End Sub

'#End Region  ' #AppointmentInserting
'#Region "#AppointmentChanging"
        Private Sub SchedulerStorage1_AppointmentChanging(ByVal sender As Object, ByVal e As PersistentObjectCancelEventArgs)
            Dim busyKey As Object = schedulerStorage1.Appointments.Statuses.GetByType(AppointmentStatusType.Busy).Id
            If CType(e.Object, Appointment).StatusKey Is busyKey Then e.Cancel = True
        End Sub
'#End Region  ' #AppointmentChanging
    End Class
End Namespace
