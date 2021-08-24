Namespace SimpleCustomFields
	Partial Public Class MyAppointmentForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.lblAmount = New DevExpress.XtraEditors.LabelControl()
			Me.calcAmount = New DevExpress.XtraEditors.CalcEdit()
			Me.mruEdit1 = New DevExpress.XtraEditors.MRUEdit()
			Me.tbContact = New DevExpress.XtraEditors.MemoEdit()
			Me.lblContactInfo = New DevExpress.XtraEditors.LabelControl()
			Me.carsDBDataSet_Conflict = New SimpleCustomFields.CarsDBDataSet()
			CType(Me.chkAllDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtStartTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtEndTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtLabel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtShowTimeAs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtResource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtResources.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtResources.ResourcesCheckedListBoxControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkReminder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbReminder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			Me.progressPanel.SuspendLayout()
			CType(Me.tbProgress, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbProgress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.calcAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.mruEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbContact.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carsDBDataSet_Conflict, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' lblLabel
			' 
			Me.lblLabel.Appearance.BackColor = System.Drawing.Color.Transparent
			' 
			' chkAllDay
			' 
			' 
			' btnOk
			' 
			Me.btnOk.Location = New System.Drawing.Point(16, 354)
			' 
			' btnCancel
			' 
			Me.btnCancel.Location = New System.Drawing.Point(104, 354)
			' 
			' btnDelete
			' 
			Me.btnDelete.Location = New System.Drawing.Point(192, 354)
			' 
			' btnRecurrence
			' 
			Me.btnRecurrence.Location = New System.Drawing.Point(280, 354)
			' 
			' edtStartDate
			' 
			Me.edtStartDate.EditValue = New DateTime(2005, 3, 31, 0, 0, 0, 0)
			Me.edtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {
				New DevExpress.XtraEditors.Controls.EditorButton(),
				New DevExpress.XtraEditors.Controls.EditorButton(),
				New DevExpress.XtraEditors.Controls.EditorButton(),
				New DevExpress.XtraEditors.Controls.EditorButton(),
				New DevExpress.XtraEditors.Controls.EditorButton()
			})
			Me.edtStartDate.Size = New System.Drawing.Size(126, 20)
			' 
			' edtEndDate
			' 
			Me.edtEndDate.EditValue = New DateTime(2005, 3, 31, 0, 0, 0, 0)
			Me.edtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {
				New DevExpress.XtraEditors.Controls.EditorButton(),
				New DevExpress.XtraEditors.Controls.EditorButton(),
				New DevExpress.XtraEditors.Controls.EditorButton(),
				New DevExpress.XtraEditors.Controls.EditorButton(),
				New DevExpress.XtraEditors.Controls.EditorButton()
			})
			Me.edtEndDate.Size = New System.Drawing.Size(126, 20)
			' 
			' edtStartTime
			' 
			Me.edtStartTime.EditValue = New DateTime(2005, 3, 31, 0, 0, 0, 0)
			Me.edtStartTime.Location = New System.Drawing.Point(230, 79)
			' 
			' edtEndTime
			' 
			Me.edtEndTime.EditValue = New DateTime(2005, 3, 31, 0, 0, 0, 0)
			Me.edtEndTime.Location = New System.Drawing.Point(230, 103)
			' 
			' edtLabel
			' 
			' 
			' edtShowTimeAs
			' 
			Me.edtShowTimeAs.Size = New System.Drawing.Size(222, 20)
			' 
			' tbSubject
			' 
			Me.tbSubject.Size = New System.Drawing.Size(422, 20)
			' 
			' edtResource
			' 
			' 
			' edtResources
			' 
			' 
			' 
			' 
			Me.edtResources.ResourcesCheckedListBoxControl.CheckOnClick = True
			Me.edtResources.ResourcesCheckedListBoxControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.edtResources.ResourcesCheckedListBoxControl.Location = New System.Drawing.Point(0, 0)
			Me.edtResources.ResourcesCheckedListBoxControl.Name = ""
			Me.edtResources.ResourcesCheckedListBoxControl.Size = New System.Drawing.Size(200, 100)
			Me.edtResources.ResourcesCheckedListBoxControl.TabIndex = 0
			' 
			' chkReminder
			' 
			' 
			' tbDescription
			' 
			Me.tbDescription.Location = New System.Drawing.Point(16, 280)
			Me.tbDescription.Size = New System.Drawing.Size(496, 56)
			' 
			' cbReminder
			' 
			' 
			' tbLocation
			' 
			Me.tbLocation.Size = New System.Drawing.Size(222, 20)
			' 
			' tbProgress
			' 
			Me.tbProgress.Properties.LabelAppearance.Options.UseTextOptions = True
			Me.tbProgress.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			' 
			' lblPercentComplete
			' 
			Me.lblPercentComplete.Appearance.BackColor = System.Drawing.Color.Transparent
			' 
			' lblPercentCompleteValue
			' 
			Me.lblPercentCompleteValue.Appearance.BackColor = System.Drawing.Color.Transparent
			' 
			' lblAmount
			' 
			Me.lblAmount.Location = New System.Drawing.Point(16, 183)
			Me.lblAmount.Name = "lblAmount"
			Me.lblAmount.Size = New System.Drawing.Size(27, 13)
			Me.lblAmount.TabIndex = 37
			Me.lblAmount.Text = "Amount:"
			' 
			' calcAmount
			' 
			Me.calcAmount.Location = New System.Drawing.Point(96, 180)
			Me.calcAmount.Name = "calcAmount"
			Me.calcAmount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.calcAmount.Size = New System.Drawing.Size(100, 20)
			Me.calcAmount.TabIndex = 38
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.calcAmount.EditValueChanged += new System.EventHandler(this.calcAmount_EditValueChanged);
			' 
			' mruEdit1
			' 
			Me.mruEdit1.Location = New System.Drawing.Point(352, 310)
			Me.mruEdit1.Name = "mruEdit1"
			Me.mruEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.mruEdit1.Size = New System.Drawing.Size(8, 20)
			Me.mruEdit1.TabIndex = 39
			' 
			' tbContact
			' 
			Me.tbContact.Location = New System.Drawing.Point(330, 194)
			Me.tbContact.Name = "tbContact"
			Me.tbContact.Size = New System.Drawing.Size(182, 41)
			Me.tbContact.TabIndex = 40
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.tbContact.EditValueChanged += new System.EventHandler(this.tbContact_EditValueChanged);
			' 
			' lblContactInfo
			' 
			Me.lblContactInfo.Location = New System.Drawing.Point(330, 174)
			Me.lblContactInfo.Name = "lblContactInfo"
			Me.lblContactInfo.Size = New System.Drawing.Size(65, 13)
			Me.lblContactInfo.TabIndex = 41
			Me.lblContactInfo.Text = "Contact Info:"
			' 
			' carsDBDataSet
			' 
			Me.carsDBDataSet_Conflict.DataSetName = "CarsDBDataSet"
			Me.carsDBDataSet_Conflict.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' MyAppointmentForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(528, 382)
			Me.Controls.Add(Me.mruEdit1)
			Me.Controls.Add(Me.lblAmount)
			Me.Controls.Add(Me.lblContactInfo)
			Me.Controls.Add(Me.tbContact)
			Me.Controls.Add(Me.calcAmount)
			Me.MinimumSize = New System.Drawing.Size(506, 294)
			Me.Name = "MyAppointmentForm"
			Me.Text = "MyAppointmentForm"
			Me.Controls.SetChildIndex(Me.calcAmount, 0)
			Me.Controls.SetChildIndex(Me.tbContact, 0)
			Me.Controls.SetChildIndex(Me.lblContactInfo, 0)
			Me.Controls.SetChildIndex(Me.lblAmount, 0)
			Me.Controls.SetChildIndex(Me.mruEdit1, 0)
			Me.Controls.SetChildIndex(Me.edtShowTimeAs, 0)
			Me.Controls.SetChildIndex(Me.edtEndTime, 0)
			Me.Controls.SetChildIndex(Me.edtEndDate, 0)
			Me.Controls.SetChildIndex(Me.btnRecurrence, 0)
			Me.Controls.SetChildIndex(Me.btnDelete, 0)
			Me.Controls.SetChildIndex(Me.btnCancel, 0)
			Me.Controls.SetChildIndex(Me.lblShowTimeAs, 0)
			Me.Controls.SetChildIndex(Me.lblEndTime, 0)
			Me.Controls.SetChildIndex(Me.tbLocation, 0)
			Me.Controls.SetChildIndex(Me.lblSubject, 0)
			Me.Controls.SetChildIndex(Me.lblLocation, 0)
			Me.Controls.SetChildIndex(Me.tbSubject, 0)
			Me.Controls.SetChildIndex(Me.lblStartTime, 0)
			Me.Controls.SetChildIndex(Me.btnOk, 0)
			Me.Controls.SetChildIndex(Me.edtStartDate, 0)
			Me.Controls.SetChildIndex(Me.edtStartTime, 0)
			Me.Controls.SetChildIndex(Me.panel1, 0)
			Me.Controls.SetChildIndex(Me.progressPanel, 0)
			Me.Controls.SetChildIndex(Me.tbDescription, 0)
			CType(Me.chkAllDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtStartTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtEndTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtLabel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtShowTimeAs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtResource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtResources.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtResources.ResourcesCheckedListBoxControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkReminder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbReminder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.progressPanel.ResumeLayout(False)
			Me.progressPanel.PerformLayout()
			CType(Me.tbProgress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbProgress, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.calcAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.mruEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbContact.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carsDBDataSet_Conflict, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private lblAmount As DevExpress.XtraEditors.LabelControl
		Private WithEvents calcAmount As DevExpress.XtraEditors.CalcEdit
		Private mruEdit1 As DevExpress.XtraEditors.MRUEdit
		Private WithEvents tbContact As DevExpress.XtraEditors.MemoEdit
		Private lblContactInfo As DevExpress.XtraEditors.LabelControl
'INSTANT VB NOTE: The variable carsDBDataSet was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
		Private carsDBDataSet_Conflict As CarsDBDataSet
	End Class
End Namespace