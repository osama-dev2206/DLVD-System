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
    public partial class ctrlInternationalAppInfo : UserControl
    {
        public ctrlInternationalAppInfo()
        {
            InitializeComponent();
        }


        internal void FillForm(ref clsInternationalLicense internationalLicense , int LocalLicenseID)
        {

            internationalLicense?.OnSaveGetInterLicID += UpdateLabels;

                labAppDate.Text = internationalLicense.IssueDateTime.ToString("dd/MM/yyyy");
            labIssueDate.Text = internationalLicense.IssueDateTime.ToString("dd/MM/yyyy");
            labFees.Text = clsApplicationTypes.FindAppObjByAppID((byte)clsApplicationTypes.enApplicationTypes.NewInternationalDrivingLicense).ApplicationFees.ToString("C");
            labLocalLicID.Text = LocalLicenseID.ToString();
            labExpDate.Text = internationalLicense.ExpirationDate.ToString("dd/MM/yyyy");
            labCreatedBy.Text = clsCurrentLoggedInUser.User.Username;

        }

       private  void UpdateLabels(int InternationalLicenseID , int ApplicationID)
        {
            labInternationalLicID.Text = InternationalLicenseID.ToString();
            labAppID.Text = ApplicationID.ToString();
        }

    }
}
