Imports Microsoft.VisualBasic
Imports System
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
			Me.lblPrice = New DevExpress.XtraEditors.LabelControl()
			Me.calcPrice = New DevExpress.XtraEditors.CalcEdit()
			Me.mruEdit1 = New DevExpress.XtraEditors.MRUEdit()
			Me.tbContact = New DevExpress.XtraEditors.MemoEdit()
			Me.lblContactInfo = New DevExpress.XtraEditors.LabelControl()
			CType(Me.chkAllDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtStartDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtEndDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtStartTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtEndTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtLabel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtShowTimeAs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtResource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtResources.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkReminder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbReminder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.calcPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.mruEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbContact.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
			Me.edtStartDate.EditValue = New System.DateTime(2005, 3, 31, 0, 0, 0, 0)
			Me.edtStartDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.edtStartDate.Size = New System.Drawing.Size(126, 20)
			' 
			' edtEndDate
			' 
			Me.edtEndDate.EditValue = New System.DateTime(2005, 3, 31, 0, 0, 0, 0)
			Me.edtEndDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.edtEndDate.Size = New System.Drawing.Size(126, 20)
			' 
			' edtStartTime
			' 
			Me.edtStartTime.EditValue = New System.DateTime(2005, 3, 31, 0, 0, 0, 0)
			Me.edtStartTime.Location = New System.Drawing.Point(230, 79)
			' 
			' edtEndTime
			' 
			Me.edtEndTime.EditValue = New System.DateTime(2005, 3, 31, 0, 0, 0, 0)
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
			' lblPrice
			' 
			Me.lblPrice.Location = New System.Drawing.Point(16, 183)
			Me.lblPrice.Name = "lblPrice"
			Me.lblPrice.Size = New System.Drawing.Size(27, 13)
			Me.lblPrice.TabIndex = 37
			Me.lblPrice.Text = "Price:"
			' 
			' calcPrice
			' 
			Me.calcPrice.Location = New System.Drawing.Point(96, 180)
			Me.calcPrice.Name = "calcPrice"
			Me.calcPrice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.calcPrice.Size = New System.Drawing.Size(100, 20)
			Me.calcPrice.TabIndex = 38
'			Me.calcPrice.EditValueChanged += New System.EventHandler(Me.calcPrice_EditValueChanged);
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
'			Me.tbContact.EditValueChanged += New System.EventHandler(Me.tbContact_EditValueChanged);
			' 
			' lblContactInfo
			' 
			Me.lblContactInfo.Location = New System.Drawing.Point(330, 174)
			Me.lblContactInfo.Name = "lblContactInfo"
			Me.lblContactInfo.Size = New System.Drawing.Size(65, 13)
			Me.lblContactInfo.TabIndex = 41
			Me.lblContactInfo.Text = "Contact Info:"
			' 
			' MyAppointmentForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(528, 382)
			Me.Controls.Add(Me.mruEdit1)
			Me.Controls.Add(Me.lblPrice)
			Me.Controls.Add(Me.lblContactInfo)
			Me.Controls.Add(Me.tbContact)
			Me.Controls.Add(Me.calcPrice)
			Me.MinimumSize = New System.Drawing.Size(506, 294)
			Me.Name = "MyAppointmentForm"
			Me.Text = "MyAppointmentForm"
			CType(Me.chkAllDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtStartDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtEndDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtStartTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtEndTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtLabel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtShowTimeAs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtResource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtResources.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkReminder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbReminder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.calcPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.mruEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbContact.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private lblPrice As DevExpress.XtraEditors.LabelControl
		Private WithEvents calcPrice As DevExpress.XtraEditors.CalcEdit
		Private mruEdit1 As DevExpress.XtraEditors.MRUEdit
		Private WithEvents tbContact As DevExpress.XtraEditors.MemoEdit
		Private lblContactInfo As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace