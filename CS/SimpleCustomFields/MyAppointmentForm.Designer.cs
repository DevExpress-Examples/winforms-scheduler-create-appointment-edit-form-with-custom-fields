namespace SimpleCustomFields
{
    partial class MyAppointmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPrice = new DevExpress.XtraEditors.LabelControl();
            this.calcPrice = new DevExpress.XtraEditors.CalcEdit();
            this.mruEdit1 = new DevExpress.XtraEditors.MRUEdit();
            this.tbContact = new DevExpress.XtraEditors.MemoEdit();
            this.lblContactInfo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLabel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtShowTimeAs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReminder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbReminder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mruEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContact.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLabel
            // 
            this.lblLabel.Appearance.BackColor = System.Drawing.Color.Transparent;
            // 
            // chkAllDay
            // 
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(16, 354);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(104, 354);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(192, 354);
            // 
            // btnRecurrence
            // 
            this.btnRecurrence.Location = new System.Drawing.Point(280, 354);
            // 
            // edtStartDate
            // 
            this.edtStartDate.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtStartDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtStartDate.Size = new System.Drawing.Size(126, 20);
            // 
            // edtEndDate
            // 
            this.edtEndDate.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtEndDate.Size = new System.Drawing.Size(126, 20);
            // 
            // edtStartTime
            // 
            this.edtStartTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtStartTime.Location = new System.Drawing.Point(230, 79);
            // 
            // edtEndTime
            // 
            this.edtEndTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtEndTime.Location = new System.Drawing.Point(230, 103);
            // 
            // edtLabel
            // 
            // 
            // edtShowTimeAs
            // 
            this.edtShowTimeAs.Size = new System.Drawing.Size(222, 20);
            // 
            // tbSubject
            // 
            this.tbSubject.Size = new System.Drawing.Size(422, 20);
            // 
            // edtResource
            // 
            // 
            // edtResources
            // 
            // 
            // chkReminder
            // 
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(16, 280);
            this.tbDescription.Size = new System.Drawing.Size(496, 56);
            // 
            // cbReminder
            // 
            // 
            // tbLocation
            // 
            this.tbLocation.Size = new System.Drawing.Size(222, 20);
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(16, 183);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(27, 13);
            this.lblPrice.TabIndex = 37;
            this.lblPrice.Text = "Price:";
            // 
            // calcPrice
            // 
            this.calcPrice.Location = new System.Drawing.Point(96, 180);
            this.calcPrice.Name = "calcPrice";
            this.calcPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcPrice.Size = new System.Drawing.Size(100, 20);
            this.calcPrice.TabIndex = 38;
            this.calcPrice.EditValueChanged += new System.EventHandler(this.calcPrice_EditValueChanged);
            // 
            // mruEdit1
            // 
            this.mruEdit1.Location = new System.Drawing.Point(352, 310);
            this.mruEdit1.Name = "mruEdit1";
            this.mruEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mruEdit1.Size = new System.Drawing.Size(8, 20);
            this.mruEdit1.TabIndex = 39;
            // 
            // tbContact
            // 
            this.tbContact.Location = new System.Drawing.Point(330, 194);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(182, 41);
            this.tbContact.TabIndex = 40;
            this.tbContact.EditValueChanged += new System.EventHandler(this.tbContact_EditValueChanged);
            // 
            // lblContactInfo
            // 
            this.lblContactInfo.Location = new System.Drawing.Point(330, 174);
            this.lblContactInfo.Name = "lblContactInfo";
            this.lblContactInfo.Size = new System.Drawing.Size(65, 13);
            this.lblContactInfo.TabIndex = 41;
            this.lblContactInfo.Text = "Contact Info:";
            // 
            // MyAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 382);
            this.Controls.Add(this.mruEdit1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblContactInfo);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.calcPrice);
            this.MinimumSize = new System.Drawing.Size(506, 294);
            this.Name = "MyAppointmentForm";
            this.Text = "MyAppointmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.chkAllDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLabel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtShowTimeAs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReminder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbReminder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mruEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContact.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblPrice;
        private DevExpress.XtraEditors.CalcEdit calcPrice;
        private DevExpress.XtraEditors.MRUEdit mruEdit1;
        private DevExpress.XtraEditors.MemoEdit tbContact;
        private DevExpress.XtraEditors.LabelControl lblContactInfo;
    }
}