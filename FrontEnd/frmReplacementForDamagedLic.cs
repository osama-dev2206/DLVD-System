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
    public partial class frmReplacementForDamagedLic : Form
    {
        public frmReplacementForDamagedLic()
        {
            InitializeComponent();
            this.ctrlFilterFindLicenseByLicid1.OnActionGetLicenseObjByLicID += CtrlFilterFindBy1_OnPersonFound;
            this.ctrlFilterFindLicenseByLicid1.OnError += CtrlFilterFindBy1_OnError;
        }

        int OldLicenseID = -1 ;
        clsReplacementLicense ? ReplacementForDamagedOrLost; 
        void CtrlFilterFindBy1_OnPersonFound(clsLicenses Lic)
        {
            btnIssue.Enabled = true;
            this.labLicHistory.Enabled = true;
            this.labNewLicenseInfo.Enabled = true;
            this.ctrlDriverLicenseInfo1.Enabled = true;
            this.grbReplacementFor.Enabled = true;
            ctrlDriverLicenseInfo1.FillForm(ApplicaionID:Lic.LicenseApplicationID);
            OldLicenseID = Lic.LicenseID;
          

            ReplacementForDamagedOrLost = new clsReplacementLicense(clsReplacementLicense.enReplacementFor.DamagedLicense, this.OldLicenseID); // Default 
        }
        
        void CtrlFilterFindBy1_OnError(bool Error)
        {
            if (Error)
            {
                btnIssue.Enabled = false;
                this.labLicHistory.Enabled = false;
                this.labNewLicenseInfo.Enabled = false;
                this.ctrlDriverLicenseInfo1.Enabled = false;
                this.grbReplacementFor.Enabled = false;
            }
        }

        void rbDamagedOrLostLic_CheckedChanged(object sender, EventArgs e)
        {
            if (this.OldLicenseID != -1)
            {
                if (rbDamagedLic.Checked)
                {
                    ReplacementForDamagedOrLost = new clsReplacementLicense(clsReplacementLicense.enReplacementFor.DamagedLicense, this.OldLicenseID);
                    return;
                }
                if (rbLostLic.Checked)
                {
                    ReplacementForDamagedOrLost = new clsReplacementLicense(clsReplacementLicense.enReplacementFor.LostLicense, this.OldLicenseID);
                    return; 
                }
            }
        }


        void labLicHistory_LinkClicked(object sender, EventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(ApplicantPersonID : this.ReplacementForDamagedOrLost.ApplicationForReplacement.ApplicantPersonID);
            frm?.ShowDialog();
            frm?.Dispose();
        }

        void labNewLicenseInfo_LinkClicked(object sender, EventArgs e)
        {
            frmShowLicense showLicense = new frmShowLicense(MainApplicaionID: this.ReplacementForDamagedOrLost.ApplicationForReplacement.ApplicationID);
            showLicense?.ShowDialog();
            showLicense?.Dispose();
        }

        void btnIssue_Click(object sender, EventArgs e)
        {
            if(this.ReplacementForDamagedOrLost.Save())
            {
                MessageBox.Show("Replacement License Issued Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error Issuing Replacement License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }

}
