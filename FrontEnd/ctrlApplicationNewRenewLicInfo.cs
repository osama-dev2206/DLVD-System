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
    public partial class ctrlApplicationNewRenewLicInfo : UserControl
    {
        public ctrlApplicationNewRenewLicInfo()
        {
            InitializeComponent();
        }

        private clsRenewLicense LocalRenewLicense;
        internal void FillForm(ref clsRenewLicense renewLicense, int OldLicenseID)
        {
            LocalRenewLicense = renewLicense;
            renewLicense.OnSavingGetInfo += UpdateRenewInfo; // to get app id and license id when saving the renew license info

            this.labAppFees.Text = renewLicense.RenewApplication.PaidFee.ToString();
            this.labAppDate.Text = DateOnly.FromDateTime(Convert.ToDateTime(renewLicense.RenewApplication.ApplicationDateTime)).ToString();
            this.labOldLicID.Text = OldLicenseID.ToString();
            this.labCreatedBy.Text = clsCurrentLoggedInUser.User.Username;

            decimal LicFees = clsLicenseClasses.FindLicenseClassByID(clsLicenses.GetLicenseObjByLicenseID(OldLicenseID).LicenseClassID).ClassFees;
            this.labLicFees.Text = LicFees.ToString();
            this.labTotalFees.Text = (LicFees + LocalRenewLicense.RenewApplication.PaidFee).ToString();
        }

        private void UpdateRenewInfo(int ApplicationID, int LicenseID)
        {
            this.labRenewAppID.Text = ApplicationID.ToString();
            this.labNewLicID.Text = LicenseID.ToString();

            this.labIssueDate.Text = LocalRenewLicense.NewLicense.IssueDate.ToString();
            this.labExpDate.Text = LocalRenewLicense.NewLicense.ExpirationDate.ToString();
        }

        internal Action<string> OnNoteChange;

        private void tbNotes_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNotes.Text))
            {
                OnNoteChange?.Invoke(tbNotes.Text);
            }
        }


    }
}
