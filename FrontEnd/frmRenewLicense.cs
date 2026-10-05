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
        int ApplicantPersonID = -1;
        int OldLicenseID = -1;
        void CtrlFilterFindLicenseByLicid1_OnLicenseSelected(clsLicenses OldLic)
        {
            OldLicenseID = OldLic.LicenseID;
            ctrlRenewApplicationInfo1.Enabled = true;
            tbNotes.Enabled = true;
            this.btnRenew.Enabled = true;
            ApplicantPersonID = clsApplications.GetApplicationObjByAppID(OldLic.LicenseApplicationID).ApplicantPersonID;
            labNewLicenseInfo.Enabled = true;
            labShowLicenseHistory.Enabled = true;
            ctrlDriverInfo1.Enabled = true;
            this.ctrlDriverInfo1.FillForm(OldLic.LicenseApplicationID);
            Renew = new clsRenewLicense(OldLicenseID: OldLic.LicenseID);
            ctrlApplicationInfo1.Enabled = true;
            this.ctrlApplicationInfo1.FillCtrlInfoByApplicationID(OldLic.LicenseApplicationID);

        }

        void CtrlFilterFindLicenseByLicid1_OnError(bool error)
        {
            if (error)
            {
                ctrlRenewApplicationInfo1.Enabled = false;
                this.btnRenew.Enabled = false;
                labNewLicenseInfo.Enabled = false;
                labShowLicenseHistory.Enabled = false;
                ctrlDriverInfo1.Enabled = false;
                ctrlApplicationInfo1.Enabled = false;
                tbNotes.Enabled = false;
            }
        }

        private void Renew_Click(object sender, EventArgs e)
        {
            if (Renew is null)
            {
                MessageBox.Show("Invalid License", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Renew.Save())
            {
                MessageBox.Show("License renewed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.btnRenew.Enabled = false;
                ctrlRenewApplicationInfo1.FillForm(Renew.LicenseID, OldLicenseID);
            }
            else
            {
                MessageBox.Show("Error in renewing the license(Check Expire Date and make sure it is active license).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void labShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory licenseHistory = new frmLicenseHistory(ApplicantPersonID: ApplicantPersonID);
            licenseHistory.ShowDialog();
            licenseHistory.Dispose();
        }

        private void labNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicense showLicense = new frmShowLicense(Renew.ApplicationID);
            showLicense?.ShowDialog();
            showLicense?.Dispose();
        }


        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbNotes_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(tbNotes.Text))
            {
                Renew.Notes = tbNotes.Text;
            }
        }


    }
}
