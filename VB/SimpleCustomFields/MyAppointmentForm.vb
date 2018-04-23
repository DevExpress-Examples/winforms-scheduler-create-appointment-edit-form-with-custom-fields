Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
#Region "#usingsform"
Imports DevExpress.XtraScheduler.UI
Imports DevExpress.XtraScheduler
#End Region ' #usingsform

Namespace SimpleCustomFields
	Partial Public Class MyAppointmentForm
		Inherits DevExpress.XtraScheduler.UI.AppointmentForm
		Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment)
			MyBase.New(control, apt)
		End Sub

		Protected Overrides Sub UpdateForm()
			' Required to initialize controls that represent custom fields
			InitializeComponent()
			MyBase.UpdateForm()
		End Sub
		#Region "#Form-Controller"
		Protected Overrides Function CreateController(ByVal control As SchedulerControl, ByVal apt As Appointment) As AppointmentFormController
			Return New MyAppointmentFormController(control, apt)
		End Function

		Protected Overrides Sub UpdateCustomFieldsControls()
			calcPrice.Value = (CType(MyBase.Controller, MyAppointmentFormController)).Price
			tbContact.Text = (CType(MyBase.Controller, MyAppointmentFormController)).ContactInfo
			MyBase.UpdateCustomFieldsControls()
		End Sub

		Private Sub calcPrice_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles calcPrice.EditValueChanged
			CType(MyBase.Controller, MyAppointmentFormController).Price = calcPrice.Value
		End Sub

		Private Sub tbContact_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbContact.EditValueChanged
			CType(MyBase.Controller, MyAppointmentFormController).ContactInfo = tbContact.Text
		End Sub
		#End Region ' #Form-Controller
	End Class

	Friend Class MyAppointmentFormController
		Inherits AppointmentFormController
		Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment)
			MyBase.New(control, apt)
		End Sub
		#Region "#CustomFieldProperties"
		Public Property Price() As Decimal
			Get
				If (Not MyBase.EditedAppointmentCopy.CustomFields("Price").Equals(System.DBNull.Value)) Then
				Return Convert.ToDecimal(MyBase.EditedAppointmentCopy.CustomFields("Price"))
				End If
			Return 0.0D
			End Get
			Set(ByVal value As Decimal)
				MyBase.EditedAppointmentCopy.CustomFields("Price") = value
			End Set
		End Property
		Public Property ContactInfo() As String
			Get
				Return MyBase.EditedAppointmentCopy.CustomFields("ContactInfo").ToString()
			End Get
			Set(ByVal value As String)
				MyBase.EditedAppointmentCopy.CustomFields("ContactInfo") = value
			End Set
		End Property

		Public Property SourcePrice() As Decimal
			Get
				Return Convert.ToDecimal(MyBase.SourceAppointment.CustomFields("Price"))
			End Get
			Set(ByVal value As Decimal)
				MyBase.SourceAppointment.CustomFields("Price") = value
			End Set
		End Property
		Public Property SourceContactInfo() As String
			Get
				Return MyBase.SourceAppointment.CustomFields("ContactInfo").ToString()
			End Get
			Set(ByVal value As String)
				MyBase.SourceAppointment.CustomFields("ContactInfo") = value
			End Set
		End Property
		#End Region ' #CustomFieldProperties

		' Indicate whether an occurrence should be converted into an exception when the Recurrence Form is invoked
		#Region "#IsAppointmentChanged"
		Public Overrides Function IsAppointmentChanged() As Boolean
			If MyBase.IsAppointmentChanged() Then
				Return True
			End If
			Return SourcePrice <> Price OrElse SourceContactInfo <> ContactInfo
		End Function
		#End Region ' #IsAppointmentChanged
		#Region "#ApplyCustomFieldsValues"
		Protected Overrides Sub ApplyCustomFieldsValues()
			MyBase.SourceAppointment.CustomFields("Price") = Price
			MyBase.SourceAppointment.CustomFields("ContactInfo") = ContactInfo
			MyBase.ApplyCustomFieldsValues()
		End Sub
		#End Region ' #ApplyCustomFieldsValues
	End Class
End Namespace