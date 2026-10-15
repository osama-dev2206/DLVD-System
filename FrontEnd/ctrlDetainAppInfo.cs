using BussinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks.Sources;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class ctrlDetainAppInfo : UserControl
    {
        public ctrlDetainAppInfo()
        {
            InitializeComponent();
        }

        private void tbFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;

            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                return;
            }

            if (e.KeyChar == '.' && textBox != null &&
                !textBox.Text.Contains(".") &&
                textBox.SelectionStart != 0)
            {
                return;
            }

            e.Handled = true;
        }
        decimal FineFees;
        clsDetainReleaseLicense LdetainLicense;
        internal void FillForm(ref clsDetainReleaseLicense detainLicense, int OGLicenseId)
        {
            LdetainLicense = detainLicense;
            detainLicense.OnSaveGetDetainInfo += UpdateForm;
            this.labDetainDate.Text = detainLicense.DetainDateTime.ToString("d-MM-yyyy");

            this.labLicenseID.Text = OGLicenseId.ToString();
            this.labCreatedBy.Text = clsCurrentLoggedInUser.User.Username;

        }

        void UpdateForm(int DetainLicenseID)
        {
            this.labDetainID.Text = DetainLicenseID.ToString();
        }

        private void tbFineFees_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(this.tbFineFees.Text))
            {
                LdetainLicense.FineFees = Convert.ToDecimal(tbFineFees.Text); 
            }    
        }
    }
}
