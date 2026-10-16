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
    public partial class frmReleaseLicense : Form
    {
        public frmReleaseLicense()
        {
            InitializeComponent();
            this.btnRelease.Enabled = false;
            this.labLisHistory.Enabled = false;
            this.labShowNewLicense.Enabled = false;

            this.ctrlFilterFindLicenseByLicid1.OnActionGetLicenseObjByLicID += CtrlFilterFindLicenseByLicid1_OnActionGetLicenseObjByLicID;
            this.ctrlFilterFindLicenseByLicid1.OnError += CtrlFilterFindLicenseByLicid1_OnError;
        }

        public frmReleaseLicense(int LicenseID)
        {
            InitializeComponent();
            this.btnRelease.Enabled = false;
            this.labLisHistory.Enabled = false;
            this.labShowNewLicense.Enabled = false;

            clsLicenses lic = clsLicenses.GetLicenseObjByLicenseID(LicenseID);
            if(lic is not null)
            {
                this.ctrlFilterFindLicenseByLicid1.Enabled = false; // disable the search control as we already have the license ID
                CtrlFilterFindLicenseByLicid1_OnActionGetLicenseObjByLicID(lic);
            }
            else
            {
                CtrlFilterFindLicenseByLicid1_OnError(true); 
            }

        }

        clsDetainReleaseLicense? releaseLicense = null;

        int PersonID = -1;
        int ApplicationID = -1;
        void CtrlFilterFindLicenseByLicid1_OnActionGetLicenseObjByLicID(clsLicenses Lic)
        {
            ApplicationID = Lic.LicenseApplicationID;
            ctrlDriverLicenseInfo1.Enabled = true;
            this.ctrlDriverLicenseInfo1.FillForm(ApplicationID);
            PersonID = clsApplications.GetApplicationObjByAppID(Lic.LicenseApplicationID).ApplicantPersonID;

            releaseLicense = clsDetainReleaseLicense.GetDetainReleaseLicenseObjByLicenseID(Lic.LicenseID); // Get the detain/release license object by license ID ,
                                                                                                           // if it isnot detained before it will return null
            if (releaseLicense != null)
            {
                this.btnRelease.Enabled = true;
                this.labLisHistory.Enabled = true;
                this.labShowNewLicense.Enabled = false;
                ctrlReleaseAppInfo1.Enabled = true;
                this.ctrlReleaseAppInfo1.FillForm(releaseLicense);
            }
            else
            {
                MessageBox.Show("This license is not detained before, so it cannot be released.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnRelease.Enabled = false;
                this.labLisHistory.Enabled = true;
                this.labShowNewLicense.Enabled = false;
                this.ctrlReleaseAppInfo1.Enabled = false;
            }


        }

        void CtrlFilterFindLicenseByLicid1_OnError(bool error)
        {
            if (error)
            {
                this.btnRelease.Enabled = false;
                this.labLisHistory.Enabled = false; 
                ctrlReleaseAppInfo1.Enabled = false;
                this.labShowNewLicense.Enabled = false;
                this.ctrlDriverLicenseInfo1.Enabled = false;
            }
        }

        private void labShowNewLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmShowLicense showLicense = new frmShowLicense(MainApplicaionID: this.ApplicationID);
            showLicense?.ShowDialog();
            showLicense?.Dispose();
        }

        private void labLisHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            frmLicenseHistory licenseHistory = new frmLicenseHistory(ApplicantPersonID: PersonID);
            licenseHistory?.ShowDialog();
            licenseHistory?.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if(releaseLicense == null)
            {
                MessageBox.Show("This license is not detained before, so it cannot be released.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else
            {
                if(this.releaseLicense.Save())
                {
                    MessageBox.Show("The License has been released successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.labShowNewLicense.Enabled = true;
                    this.ctrlDriverLicenseInfo1.FillForm(ApplicationID); // refresh the license info after release
                    this.btnRelease.Enabled = false; // disable the release button after release
                    this.ctrlFilterFindLicenseByLicid1.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Error: The License could not be released. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }



    }
}
