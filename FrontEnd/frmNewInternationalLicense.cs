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
        int PersonID = -1;
        public frmNewInternationalLicense()
        {
            InitializeComponent();
            this.btnIssue.Enabled = false;
            labLicenseHistory.Enabled = false;
            labLicenseInfo.Enabled = false;

            this.ctrlFilterFindLicenseByLicid1.OnActionGetLicenseObjByLicID += CtrlFilterFindLicenseByLicid1_OnActionGetLicenseObj;
            this.ctrlFilterFindLicenseByLicid1.OnError += CtrlFilterFindLicenseByLicid1_OnError;
        }

        void ShowInfoIfLicenseExist(clsLicenses Lic)
        {
            this.International = clsInternationalLicense.GetObjInternationalLicByLocalLicenseID(Lic.LicenseID);
            this.btnIssue.Enabled = false;
            ctrlInternationalAppInfo1.FillFormIfTheLicenseExists(internationalLicense: ref this.International, LocalLicenseID: Lic.LicenseID);

            this.ctrlDriverInfo1.FillForm(Lic.LicenseApplicationID);
        }


        // From ctrlFilterFindLicenseByLicid1 when the user enters a license id 
        void CtrlFilterFindLicenseByLicid1_OnActionGetLicenseObj(clsLicenses Lic) // this event will be triggered when the user selects a license from the search control (and it exists)
        {
            labLicenseHistory.Enabled = true;
            this.labLicenseInfo.Enabled = true;
            this.ctrlInternationalAppInfo1.Enabled = true;
            this.ctrlDriverInfo1.Enabled = true;
            this.LicenseID = Lic.LicenseID;
            PersonID = clsApplications.GetApplicationObjByAppID(Lic.LicenseApplicationID).ApplicantPersonID;


            // if the person Has an active International License , Show Its Info
            if (clsInternationalLicense.IsPersonHasActiveInternationalLicenseByLicenseID(Lic.LicenseID))
            {
                ShowInfoIfLicenseExist(Lic);
                return; 
            }

            // Otherwise , Enable the controls to allow the user to issue a new International License
            this.ctrlDriverInfo1.FillForm(Lic.LicenseApplicationID);
            this.btnIssue.Enabled = true;
   
            International = new clsInternationalLicense(Lic.LicenseID);  // الدولي

            ctrlInternationalAppInfo1.FillForm(internationalLicense: ref this.International, LocalLicenseID: Lic.LicenseID);

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
           DialogResult R =  MessageBox.Show("Are you sure you want to issue the International License?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (R == DialogResult.Yes)
            {

                if (this.International.Save())
                {
                    MessageBox.Show("International License Issued Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    labLicenseInfo.Enabled = true;
                    this.LicenseID = this.International.LicenseID;
                    this.btnIssue.Enabled = false;
                }

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
