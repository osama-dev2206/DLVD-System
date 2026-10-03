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
    public partial class frmNewInternationalLicense : Form
    {
        clsInternationalLicense? International;
        int LicenseID = -1;
        public frmNewInternationalLicense()
        {
            InitializeComponent();
            this.btnIssue.Enabled = false;
            labLicenseHistory.Enabled = false;
            labLicenseInfo.Enabled = false;

            this.ctrlFilterFindLicenseByLicid1.OnActionGetLicenseObjByLicID += CtrlFilterFindLicenseByLicid1_OnActionGetLicenseObj;
            this.ctrlFilterFindLicenseByLicid1.OnError += CtrlFilterFindLicenseByLicid1_OnError;
        }

        // From ctrlFilterFindLicenseByLicid1 when the user enters a license id 
        int PersonID = -1;
        void CtrlFilterFindLicenseByLicid1_OnActionGetLicenseObj(clsLicenses Lic) // this event will be triggered when the user selects a license from the search control (and it exists)
        {
            this.ctrlInternationalAppInfo1.Enabled = true;
            this.ctrlDriverInfo1.Enabled = true;
            this.LicenseID = Lic.LicenseID;
            this.labLicenseInfo.Enabled = true;
            PersonID = clsApplications.GetApplicationObjByAppID(Lic.LicenseApplicationID).ApplicantPersonID;
            this.ctrlDriverInfo1.FillForm(Lic.LicenseApplicationID);
            ctrlInternationalAppInfo1.FillForm(Lic.LicenseID);
            this.btnIssue.Enabled = true;
            labLicenseHistory.Enabled = true;

            International = new clsInternationalLicense(Lic.LicenseID);  // الدولي
            International.OnActionGetError += GetErrorWhenSaving;
        }

        void CtrlFilterFindLicenseByLicid1_OnError(bool Error) // From ctrlFilterFindLicenseByLicid1 when the user enters a license id 
        {
            this.btnIssue.Enabled = false;
            this.ctrlDriverInfo1.Enabled = false;
            this.ctrlInternationalAppInfo1.Enabled = false;
            this.labLicenseHistory.Enabled = false;
            this.labLicenseInfo.Enabled = false;
        }

        void GetErrorWhenSaving(string ErrorMessage) // Error From clsInternationalLicense when saving the new international license to the database
        {
            MessageBox.Show(ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (this.International.Save())
            {
                MessageBox.Show("International License Issued Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labLicenseInfo.Enabled = true;
                this.LicenseID = this.International.LicenseID;
                this.btnIssue.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (PersonID is not -1)
            {
                frmLicenseHistory frm = new frmLicenseHistory(PersonID);
                frm?.ShowDialog();
                frm?.Dispose();
            }
        }

        private void labLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowInternationalLicenseInfo licenseInfo = new frmShowInternationalLicenseInfo(this.LicenseID);
                licenseInfo?.ShowDialog();
                licenseInfo?.Dispose();
  

        }


    }
}
