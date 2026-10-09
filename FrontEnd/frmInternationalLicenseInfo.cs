using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class frmShowInternationalLicenseInfo : Form
    {
        public frmShowInternationalLicenseInfo(int LicenseID)
        {
            InitializeComponent();
            this.ctrlDriverInternationalInfo1.OnFailedToGetLicenseInfo += CtrlDriverInternationalInfo1_OnFailedToGetLicenseInfo;

            this.ctrlDriverInternationalInfo1.FillForm(LicenseID: LicenseID); /// internatioanl 
 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CtrlDriverInternationalInfo1_OnFailedToGetLicenseInfo(bool obj)
        {
            MessageBox.Show("Failed to get international license info.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


    }
}
