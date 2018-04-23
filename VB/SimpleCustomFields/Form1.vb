Imports Microsoft.VisualBasic
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

			Me.schedulerControl1.Start = New DateTime(2010, 07, 01)
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'carsDBDataSet.Cars' table. You can move, or remove it, as needed.
			Me.carsTableAdapter.Fill(Me.carsDBDataSet.Cars)
			' TODO: This line of code loads data into the 'carsDBDataSet.CarScheduling' table. You can move, or remove it, as needed.
			Me.carSchedulingTableAdapter.Fill(Me.carsDBDataSet.CarScheduling)
			AddHandler carSchedulingTableAdapter.Adapter.RowUpdated, AddressOf carSchedulingTableAdapter_RowUpdated

		End Sub

		Private Sub OnApptChangedInsertedDeleted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs) Handles schedulerStorage1.AppointmentsInserted, schedulerStorage1.AppointmentsDeleted, schedulerStorage1.AppointmentsChanged
			carSchedulingTableAdapter.Update(carsDBDataSet)
			carsDBDataSet.AcceptChanges()
		End Sub

		Private Sub carSchedulingTableAdapter_RowUpdated(ByVal sender As Object, ByVal e As OleDbRowUpdatedEventArgs)
			If e.Status = UpdateStatus.Continue AndAlso e.StatementType = StatementType.Insert Then
				Dim id As Integer = 0
				Using cmd As New OleDbCommand("SELECT @@IDENTITY", carSchedulingTableAdapter.Connection)
					id = CInt(Fix(cmd.ExecuteScalar()))
				End Using
				e.Row("ID") = id
			End If
		End Sub
		#Region "#EditAppointmentFormShowing"
		Private Sub schedulerControl1_EditAppointmentFormShowing(ByVal sender As Object, ByVal e As AppointmentFormEventArgs) Handles schedulerControl1.EditAppointmentFormShowing
			Dim myForm As New MyAppointmentForm(Me.schedulerControl1, e.Appointment)
			' Required for skin support
			myForm.LookAndFeel.ParentLookAndFeel = schedulerControl1.LookAndFeel
			e.DialogResult = myForm.ShowDialog()
			e.Handled = True
		End Sub
		#End Region ' #EditAppointmentFormShowing

		#Region "#InitNewAppointment"
		Private Sub schedulerControl1_InitNewAppointment(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.AppointmentEventArgs) Handles schedulerControl1.InitNewAppointment
			e.Appointment.Description &= "Created at runtime at " & String.Format("{0:g}", DateTime.Now)
			e.Appointment.CustomFields("Price") = 00.01R
			e.Appointment.CustomFields("ContactInfo") = "someone@somecompany.com"
		End Sub
		#End Region ' #InitNewAppointment

		Private Sub schedulerStorage1_AppointmentInserting(ByVal sender As Object, ByVal e As PersistentObjectCancelEventArgs) Handles schedulerStorage1.AppointmentInserting
			Dim apt As Appointment = (CType(e.Object, Appointment))
			apt.Description += Constants.vbCrLf & "Inserting at " & String.Format("{0:g}", DateTime.Now)
			apt.Description += Constants.vbCrLf & " Price: " & apt.CustomFields("Price")
		End Sub

		Private Sub schedulerStorage1_AppointmentChanging(ByVal sender As Object, ByVal e As PersistentObjectCancelEventArgs) Handles schedulerStorage1.AppointmentChanging
			Dim apt As Appointment = (CType(e.Object, Appointment))
			apt.Description += Constants.vbCrLf & "Changing at " & String.Format("{0:g}", DateTime.Now)
			apt.Description += Constants.vbCrLf & " Price: " & apt.CustomFields("Price")
		End Sub
	End Class
End Namespace