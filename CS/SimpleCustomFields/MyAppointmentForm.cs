using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
#region #usingsform
using DevExpress.XtraScheduler.UI;
using DevExpress.XtraScheduler;
#endregion #usingsform

namespace SimpleCustomFields {
    public partial class MyAppointmentForm : DevExpress.XtraScheduler.UI.AppointmentForm {
        public MyAppointmentForm(SchedulerControl control, Appointment apt) : base(control, apt) {
            // Required to initialize controls that represent custom fields
            InitializeComponent();
        }

        public override void LoadFormData(Appointment apt)
        {
            base.LoadFormData(apt);
            UpdateCustomFieldEditors();
        }
        #region #Form-Controller
        protected override AppointmentFormController CreateController(SchedulerControl control, Appointment apt) {
            return new MyAppointmentFormController(control, apt);
        }

        protected void UpdateCustomFieldEditors() {
            calcPrice.Value = ((MyAppointmentFormController)base.Controller).Price;
            tbContact.Text = ((MyAppointmentFormController)base.Controller).ContactInfo;
        }

        private void calcPrice_EditValueChanged(object sender, EventArgs e) {
            ((MyAppointmentFormController)base.Controller).Price = calcPrice.Value;
        }

        private void tbContact_EditValueChanged(object sender, EventArgs e) {
            ((MyAppointmentFormController)base.Controller).ContactInfo = tbContact.Text;
        }
        #endregion #Form-Controller
        
    }

    class MyAppointmentFormController : AppointmentFormController {
        public MyAppointmentFormController(SchedulerControl control, Appointment apt)
            : base(control, apt) {
        }
        #region #CustomFieldProperties
        public decimal Price {
            get {
                if (!base.EditedAppointmentCopy.CustomFields["Price"].Equals(System.DBNull.Value))
                return Convert.ToDecimal(base.EditedAppointmentCopy.CustomFields["Price"]);
            return 0.0M;
            }
            set {
                base.EditedAppointmentCopy.CustomFields["Price"] = value;
            }
        }
        public string ContactInfo {
            get {
                return base.EditedAppointmentCopy.CustomFields["ContactInfo"].ToString();
            }
            set {
                base.EditedAppointmentCopy.CustomFields["ContactInfo"] = value;
            }
        }

        public decimal SourcePrice {
            get {
                object val = base.SourceAppointment.CustomFields["Price"];
                if (val is DBNull)
                    val = (decimal)0;
                return Convert.ToDecimal(val);
            }
            set {
                base.SourceAppointment.CustomFields["Price"] = value;
            }
        }
        public string SourceContactInfo {
            get {
                return base.SourceAppointment.CustomFields["ContactInfo"].ToString();
            }
            set {
                base.SourceAppointment.CustomFields["ContactInfo"] = value;
            }
        }
        #endregion #CustomFieldProperties

        // Indicate whether an occurrence should be converted into an exception when the Recurrence Form is invoked
        #region #IsAppointmentChanged
        public override bool IsAppointmentChanged() {
            if (base.IsAppointmentChanged())
                return true;
            return SourcePrice != Price ||
                SourceContactInfo != ContactInfo;
        }
        #endregion #IsAppointmentChanged
        #region #ApplyCustomFieldsValues
        protected override void ApplyCustomFieldsValues() {
            base.SourceAppointment.CustomFields["Price"] = Price;
            base.SourceAppointment.CustomFields["ContactInfo"] = ContactInfo;
            base.ApplyCustomFieldsValues();
        }
        #endregion #ApplyCustomFieldsValues
    }
}