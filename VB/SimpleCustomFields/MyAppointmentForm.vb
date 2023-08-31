Imports System
Imports System.ComponentModel
Imports System.Drawing
'#Region "#usingsform"
Imports DevExpress.XtraScheduler.UI
Imports DevExpress.XtraScheduler

'#End Region  ' #usingsform
Namespace SimpleCustomFields

    Public Partial Class MyAppointmentForm
        Inherits AppointmentForm

        Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment)
            MyBase.New(control, apt)
            ' Required to initialize custom field editors.
            InitializeComponent()
        End Sub

        Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment, ByVal openRecurrenceForm As Boolean)
            MyBase.New(control, apt, openRecurrenceForm)
            ' Required to initialize custom field editors.
            InitializeComponent()
        End Sub

        Public Overrides Sub LoadFormData(ByVal apt As Appointment)
            MyBase.LoadFormData(apt)
            UpdateCustomFieldEditors()
        End Sub

'#Region "#Form-Controller"
        Protected Overrides Function CreateController(ByVal control As SchedulerControl, ByVal apt As Appointment) As AppointmentFormController
            Return New MyAppointmentFormController(control, apt)
        End Function

        Protected Sub UpdateCustomFieldEditors()
            calcAmount.Value = CType(Controller, MyAppointmentFormController).Amount
            tbContact.Text = CType(Controller, MyAppointmentFormController).ContactInfo
        End Sub

        Private Sub calcAmount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            CType(Controller, MyAppointmentFormController).Amount = calcAmount.Value
        End Sub

        Private Sub tbContact_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            CType(Controller, MyAppointmentFormController).ContactInfo = tbContact.Text
        End Sub
'#End Region  ' #Form-Controller        
    End Class

    Friend Class MyAppointmentFormController
        Inherits AppointmentFormController

        Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment)
            MyBase.New(control, apt)
        End Sub

'#Region "#CustomFieldProperties"
        Public Property Amount As Decimal
            Get
                If EditedAppointmentCopy.CustomFields("Amount") IsNot Nothing Then
                    Return Convert.ToDecimal(EditedAppointmentCopy.CustomFields("Amount"))
                Else
                    Return 0.0D
                End If
            End Get

            Set(ByVal value As Decimal)
                EditedAppointmentCopy.CustomFields("Amount") = value
            End Set
        End Property

        Public Property ContactInfo As String
            Get
                If EditedAppointmentCopy.CustomFields("ContactInfo") IsNot Nothing Then
                    Return EditedAppointmentCopy.CustomFields("ContactInfo").ToString()
                Else
                    Return String.Empty
                End If
            End Get

            Set(ByVal value As String)
                EditedAppointmentCopy.CustomFields("ContactInfo") = value
            End Set
        End Property

        Public Property SourceAmount As Decimal
            Get
                If SourceAppointment.CustomFields("Amount") IsNot Nothing Then
                    Return Convert.ToDecimal(SourceAppointment.CustomFields("Amount"))
                Else
                    Return CDec(0)
                End If
            End Get

            Set(ByVal value As Decimal)
                SourceAppointment.CustomFields("Amount") = value
            End Set
        End Property

        Public Property SourceContactInfo As String
            Get
                If SourceAppointment.CustomFields("ContactInfo") IsNot Nothing Then
                    Return SourceAppointment.CustomFields("ContactInfo").ToString()
                Else
                    Return String.Empty
                End If
            End Get

            Set(ByVal value As String)
                SourceAppointment.CustomFields("ContactInfo") = value
            End Set
        End Property

'#End Region  ' #CustomFieldProperties
        ' Indicate whether an occurrence should be converted into an exception when the Recurrence Form is invoked
'#Region "#IsAppointmentChanged"
        Public Overrides Function IsAppointmentChanged() As Boolean
            If MyBase.IsAppointmentChanged() Then Return True
            Return SourceAmount <> Amount OrElse Not Equals(SourceContactInfo, ContactInfo)
        End Function

'#End Region  ' #IsAppointmentChanged
'#Region "#ApplyCustomFieldsValues"
        Protected Overrides Sub ApplyCustomFieldsValues()
            SourceAppointment.CustomFields("Amount") = Amount
            SourceAppointment.CustomFields("ContactInfo") = ContactInfo
            MyBase.ApplyCustomFieldsValues()
        End Sub
'#End Region  ' #ApplyCustomFieldsValues
    End Class
End Namespace
