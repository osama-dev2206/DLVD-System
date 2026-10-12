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
    public partial class ctrlReplacementAppInfo : UserControl
    {
        public ctrlReplacementAppInfo()
        {
            InitializeComponent();
        }


        internal void FillForm(clsReplacementLicense license , int OldLicenseID)
        {
            license?.OnSaveGetInfo = UpdateForm;
            this.labAppDate.Text = license.ApplicationForReplacement?.ApplicationDateTime.ToString("dd/MM/yyyy");
            this.labAppFees.Text = license.ApplicationForReplacement?.PaidFee.ToString("C");
            this.labOldLicID.Text = OldLicenseID.ToString();
            this.labCreatedBy.Text = clsCurrentLoggedInUser.User?.Username;
        }

        void UpdateForm(int ApplicationID , int LicenseID)
        {
            this.labReplacmentAppID.Text = ApplicationID.ToString();
            this.labReplacedLicID.Text = LicenseID.ToString();
        }

    }
}
