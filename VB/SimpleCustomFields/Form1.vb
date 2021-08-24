Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.OleDb
#Region "#usings"
Imports DevExpress.XtraScheduler
#End Region ' #usings

Namespace SimpleCustomFields
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()

			AddHandler schedulerDataStorage1.AppointmentInserting, AddressOf SchedulerStorage1_AppointmentInserting
			AddHandler schedulerDataStorage1.AppointmentsInserted, AddressOf OnApptChangedInsertedDeleted
			AddHandler schedulerDataStorage1.AppointmentChanging, AddressOf SchedulerStorage1_AppointmentChanging
			AddHandler schedulerDataStorage1.AppointmentsChanged, AddressOf OnApptChangedInsertedDeleted
			AddHandler schedulerDataStorage1.AppointmentsDeleted, AddressOf OnApptChangedInsertedDeleted

			Me.schedulerControl1.Start = New DateTime(2010, 07, 01)
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			' TODO: This line of code loads data into the 'carsDBDataSet.Cars' table. You can move, or remove it, as needed.
			Me.carsTableAdapter.Fill(Me.carsDBDataSet_Conflict.Cars)
			' TODO: This line of code loads data into the 'carsDBDataSet.CarScheduling' table. You can move, or remove it, as needed.
			Me.carSchedulingTableAdapter.Fill(Me.carsDBDataSet_Conflict.CarScheduling)
			AddHandler carSchedulingTableAdapter.Adapter.RowUpdated, AddressOf carSchedulingTableAdapter_RowUpdated

		End Sub

		Private Sub OnApptChangedInsertedDeleted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
			carSchedulingTableAdapter.Update(carsDBDataSet_Conflict)
			carsDBDataSet_Conflict.AcceptChanges()
		End Sub

		Private Sub carSchedulingTableAdapter_RowUpdated(ByVal sender As Object, ByVal e As OleDbRowUpdatedEventArgs)
			If e.Status = UpdateStatus.Continue AndAlso e.StatementType = StatementType.Insert Then
				Dim id As Integer = 0
				Using cmd As New OleDbCommand("SELECT @@IDENTITY", carSchedulingTableAdapter.Connection)
					id = DirectCast(cmd.ExecuteScalar(), Integer)
				End Using
				e.Row("ID") = id
			End If
		End Sub
		#Region "#EditAppointmentFormShowing"
		Private Sub schedulerControl1_EditAppointmentFormShowing(ByVal sender As Object, ByVal e As AppointmentFormEventArgs) Handles schedulerControl1.EditAppointmentFormShowing
			Dim form As New MyAppointmentForm(TryCast(sender, SchedulerControl), e.Appointment, e.OpenRecurrenceForm)
			Try
				e.DialogResult = form.ShowDialog()
				e.Handled = True
			Finally
				form.Dispose()
			End Try
		End Sub
		#End Region ' #EditAppointmentFormShowing

		#Region "#InitNewAppointment"
		Private Sub schedulerControl1_InitNewAppointment(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.AppointmentEventArgs) Handles schedulerControl1.InitNewAppointment
			e.Appointment.Description &= "Created at runtime at " & String.Format("{0:g}", DateTime.Now)
			e.Appointment.CustomFields("Amount") = 00.01R
			e.Appointment.CustomFields("ContactInfo") = "someone@somecompany.com"
		End Sub
		#End Region ' #InitNewAppointment
		#Region "#AppointmentInserting"
		Private Sub SchedulerStorage1_AppointmentInserting(ByVal sender As Object, ByVal e As PersistentObjectCancelEventArgs)
			If CType(e.Object, Appointment).Start < DateTime.Now Then
				e.Cancel = True
			End If
		End Sub
		#End Region ' #AppointmentInserting
		#Region "#AppointmentChanging"
		Private Sub SchedulerStorage1_AppointmentChanging(ByVal sender As Object, ByVal e As PersistentObjectCancelEventArgs)
			If CType(e, DevExpress.XtraScheduler.AdvPersistentObjectCancelEventArgs).PropertyName = "StatusKey" Then
				Return
			End If
			Dim busyKey As Object = schedulerDataStorage1.Appointments.Statuses.GetByType(AppointmentStatusType.Busy).Id
			If CType(e.Object, Appointment).StatusKey.Equals(busyKey) Then
				e.Cancel = True
			End If
		End Sub
		#End Region ' #AppointmentChanging
	End Class
End Namespace