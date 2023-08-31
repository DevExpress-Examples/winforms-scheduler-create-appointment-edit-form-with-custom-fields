Namespace SimpleCustomFields

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim timeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.carSchedulingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.carsDBDataSet = New SimpleCustomFields.CarsDBDataSet()
            Me.carsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.dateNavigator1 = New DevExpress.XtraScheduler.DateNavigator()
            Me.carSchedulingTableAdapter = New SimpleCustomFields.CarsDBDataSetTableAdapters.CarSchedulingTableAdapter()
            Me.carsTableAdapter = New SimpleCustomFields.CarsDBDataSetTableAdapters.CarsTableAdapter()
            CType((Me.schedulerControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerStorage1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.carSchedulingBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.carsDBDataSet), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.carsBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dateNavigator1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dateNavigator1.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' schedulerControl1
            ' 
            Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl1.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.Size = New System.Drawing.Size(699, 561)
            Me.schedulerControl1.Start = New System.DateTime(2010, 7, 1, 0, 0, 0, 0)
            Me.schedulerControl1.Storage = Me.schedulerStorage1
            Me.schedulerControl1.TabIndex = 0
            Me.schedulerControl1.Text = "schedulerControl1"
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
            AddHandler Me.schedulerControl1.InitNewAppointment, New DevExpress.XtraScheduler.AppointmentEventHandler(AddressOf Me.schedulerControl1_InitNewAppointment)
            AddHandler Me.schedulerControl1.EditAppointmentFormShowing, New DevExpress.XtraScheduler.AppointmentFormEventHandler(AddressOf Me.schedulerControl1_EditAppointmentFormShowing)
            ' 
            ' schedulerStorage1
            ' 
            Me.schedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("Amount", "Price"))
            Me.schedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("ContactInfo", "ContactInfo"))
            Me.schedulerStorage1.Appointments.DataSource = Me.carSchedulingBindingSource
            Me.schedulerStorage1.Appointments.Mappings.AllDay = "AllDay"
            Me.schedulerStorage1.Appointments.Mappings.Description = "Description"
            Me.schedulerStorage1.Appointments.Mappings.[End] = "EndTime"
            Me.schedulerStorage1.Appointments.Mappings.Label = "Label"
            Me.schedulerStorage1.Appointments.Mappings.Location = "Location"
            Me.schedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
            Me.schedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo"
            Me.schedulerStorage1.Appointments.Mappings.ResourceId = "CarId"
            Me.schedulerStorage1.Appointments.Mappings.Start = "StartTime"
            Me.schedulerStorage1.Appointments.Mappings.Status = "Status"
            Me.schedulerStorage1.Appointments.Mappings.Subject = "Subject"
            Me.schedulerStorage1.Appointments.Mappings.Type = "EventType"
            Me.schedulerStorage1.Resources.DataSource = Me.carsBindingSource
            Me.schedulerStorage1.Resources.Mappings.Caption = "Trademark"
            Me.schedulerStorage1.Resources.Mappings.Id = "ID"
            Me.schedulerStorage1.Resources.Mappings.Image = "Picture"
            ' 
            ' carSchedulingBindingSource
            ' 
            Me.carSchedulingBindingSource.DataMember = "CarScheduling"
            Me.carSchedulingBindingSource.DataSource = Me.carsDBDataSet
            ' 
            ' carsDBDataSet
            ' 
            Me.carsDBDataSet.DataSetName = "CarsDBDataSet"
            Me.carsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' carsBindingSource
            ' 
            Me.carsBindingSource.DataMember = "Cars"
            Me.carsBindingSource.DataSource = Me.carsDBDataSet
            ' 
            ' dateNavigator1
            ' 
            Me.dateNavigator1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Right
            Me.dateNavigator1.FirstDayOfWeek = System.DayOfWeek.Sunday
            Me.dateNavigator1.Location = New System.Drawing.Point(699, 0)
            Me.dateNavigator1.Name = "dateNavigator1"
            Me.dateNavigator1.CellPadding = New System.Windows.Forms.Padding(2)
            Me.dateNavigator1.SchedulerControl = Me.schedulerControl1
            Me.dateNavigator1.Size = New System.Drawing.Size(249, 561)
            Me.dateNavigator1.TabIndex = 1
            ' 
            ' carSchedulingTableAdapter
            ' 
            Me.carSchedulingTableAdapter.ClearBeforeFill = True
            ' 
            ' carsTableAdapter
            ' 
            Me.carsTableAdapter.ClearBeforeFill = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(948, 561)
            Me.Controls.Add(Me.schedulerControl1)
            Me.Controls.Add(Me.dateNavigator1)
            Me.Name = "Form1"
            Me.Text = "Custom Fields Example"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.schedulerControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerStorage1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.carSchedulingBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.carsDBDataSet), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.carsBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dateNavigator1.CalendarTimeProperties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dateNavigator1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl

        Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage

        Private dateNavigator1 As DevExpress.XtraScheduler.DateNavigator

        Private carsDBDataSet As SimpleCustomFields.CarsDBDataSet

        Private carSchedulingBindingSource As System.Windows.Forms.BindingSource

        Private carSchedulingTableAdapter As SimpleCustomFields.CarsDBDataSetTableAdapters.CarSchedulingTableAdapter

        Private carsBindingSource As System.Windows.Forms.BindingSource

        Private carsTableAdapter As SimpleCustomFields.CarsDBDataSetTableAdapters.CarsTableAdapter
    End Class
End Namespace
