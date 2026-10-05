using BussinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class frmRenewLicense : Form
    {
        public frmRenewLicense()
        {
            InitializeComponent();
            this.ctrlFilterFindLicenseByLicid1.OnActionGetLicenseObjByLicID += CtrlFilterFindLicenseByLicid1_OnLicenseSelected;
            this.ctrlFilterFindLicenseByLicid1.OnError += CtrlFilterFindLicenseByLicid1_OnError;
        }

        clsRenewLicense Renew;
        void CtrlFilterFindLicenseByLicid1_OnLicenseSelected (clsLicenses Lic)
        {
            this.btnRenew.Enabled = true;
            labNewLicenseInfo.Enabled = true;
            labShowLicenseHistory.Enabled = true;
            ctrlDriverInfo1.Enabled = true;
            this.ctrlDriverInfo1.FillForm(Lic.LicenseApplicationID);
            Renew = new clsRenewLicense( OldLicenseID: Lic.LicenseID);

        }

        void CtrlFilterFindLicenseByLicid1_OnError( bool error)
        {
            if (error)
            {
                this.btnRenew.Enabled = false;
                labNewLicenseInfo.Enabled = false;
                labShowLicenseHistory.Enabled = false;
                ctrlDriverInfo1.Enabled = false;
            }
        }

        private void Renew_Click(object sender, EventArgs e)
        {
            if (Renew is  null)
            {
                MessageBox.Show("Invalid License","error",MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            
                if (Renew.Save())
                {
                    MessageBox.Show("License renewed successfully.","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error in renewing the license(Check Expire Date).","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            
        }


    }
}
