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
    public partial class frmDetainLicense : Form
    {
        public frmDetainLicense()
        {
            InitializeComponent();
            this.ctrlFilterFindLicenseByLicid1.OnActionGetLicenseObjByLicID += CtrlFilterFindLicenseByLicid1_OnActionGetLicenseObjByLicID;
            this.ctrlFilterFindLicenseByLicid1.OnError += CtrlFilterFindLicenseByLicid1_OnError;
        }

        int LicenseID = -1;
        int PersonID = -1;
        int ApplicaionID = -1;
        clsDetainReleaseLicense DetainLicense;
        void CtrlFilterFindLicenseByLicid1_OnActionGetLicenseObjByLicID(clsLicenses Lic)
        {
            LicenseID = Lic.LicenseID;
            ApplicaionID = Lic.LicenseApplicationID;
            PersonID = clsApplications.GetApplicationObjByAppID(Lic.LicenseApplicationID).ApplicantPersonID;
            this.ctrlDriverLicenseInfo1.Enabled = true;
            labLicenseHistory.Enabled = true;
            labShowLic.Enabled = true;
            btnDetain.Enabled = true;

            ctrlDriverLicenseInfo1.FillForm(ApplicaionID: Lic.LicenseApplicationID);
            DetainLicense = new clsDetainReleaseLicense(LicenseID: LicenseID); // get object ready for detain license 
             this.ctrlDetainAppInfo1.FillForm(ref DetainLicense, OGLicenseId: LicenseID);
        }

        void CtrlFilterFindLicenseByLicid1_OnError(bool Error)
        {
            if (Error)
            {
                this.ctrlDriverLicenseInfo1.Enabled = false;
                labLicenseHistory.Enabled = false;
                labShowLic.Enabled = false;
                btnDetain.Enabled = false;
            }
        }

        private void labLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(ApplicantPersonID: PersonID);
            frm?.ShowDialog();
            frm?.Dispose();
        }

        private void labShowLic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicense frm = new frmShowLicense(MainApplicaionID: ApplicaionID);
            frm?.ShowDialog();
            frm?.Dispose();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if(this.DetainLicense.Save())
            {
                MessageBox.Show("The License Has Detained Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.btnDetain.Enabled = false;

                ctrlDriverLicenseInfo1.FillForm(ApplicaionID: this.ApplicaionID);// Refresh 
                this.ctrlDetainAppInfo1.FillForm(ref DetainLicense, OGLicenseId: LicenseID);// Refresh 
                this.ctrlFilterFindLicenseByLicid1.Enabled = false;
            }
            else
            {
                MessageBox.Show("This License Cannot Be Detained It May Be Detained Before Or The License Isnot Valid ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
