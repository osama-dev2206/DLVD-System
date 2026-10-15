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
            // Allow digits, decimal point, and control keys (Backspace, etc.)
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        internal void FillForm(ref clsDetainReleaseLicense detainLicense, int OGLicenseId)
        {
            detainLicense.OnSaveGetDetainInfo += UpdateForm;
            this.labDetainDate.Text = detainLicense.DetainDateTime.ToString("d-MM-yyyy");
            if (!string.IsNullOrEmpty(this.tbFineFees.Text))
            {
                detainLicense.FineFees = Convert.ToDecimal(this.tbFineFees.Text);
            }
            this.labLicenseID.Text = OGLicenseId.ToString();
            this.labCreatedBy.Text = clsCurrentLoggedInUser.User.Username;

        }

        void UpdateForm(int DetainLicenseID)
        {
            this.labDetainID.Text = DetainLicenseID.ToString();
        }

        private void tbFineFees_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
