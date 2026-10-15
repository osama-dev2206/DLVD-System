using BussinessLogicLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class ctrlReleaseAppInfo : UserControl
    {
        public ctrlReleaseAppInfo()
        {
            InitializeComponent();
        }

        internal void FillForm(clsDetainReleaseLicense Lic)
        {
            Lic .OnSaveGetDetainInfo += UpdateReleaseAppID;

            this.labDetainID.Text = Lic.DetainID.ToString();
            this.labDetainDate.Text = Lic.DetainDateTime.ToString("dd/MM/yyyy");

            decimal AppFees = clsApplicationTypes.FindAppObjByAppID((int)clsApplicationTypes.enApplicationTypes.ReleaseDetainedDrivingLicense).ApplicationFees; 

            this.labAppFees.Text = AppFees.ToString();
            this.labTotalFees.Text = (Lic.FineFees + AppFees).ToString("N2");

            this.labLicenseID.Text = Lic.LicenseID.ToString();
            this.labCreatedBy.Text = clsCurrentLoggedInUser.User.Username;
            this.labFineFees.Text = Lic.FineFees.ToString("N2");

        }

        void UpdateReleaseAppID(int Id)
        {
            this.labReleaseAppID.Text = Id.ToString();
        }

    }
}
