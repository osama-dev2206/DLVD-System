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

        internal void FillForm(int LicenseID)
        {
            DataTable International = clsInternationalLicense.GetInternationalApplicationInfo(LicenseID);


            foreach(DataRow R in International.Rows)
            {
                labAppID.Text = R["ApplicationID"].ToString();
                labAppDate.Text = R["ApplicationDateTime"].ToString();
                labIssueDate.Text = R["IssueDateTime"].ToString();
                labFees.Text = R["ApplicationFees"].ToString();
                labInternationalLicID.Text = R["InternationalLicenseID"].ToString();
                labLocalLicID.Text = R["LicenseID"].ToString();
                labExpDate.Text = DateOnly.FromDateTime(Convert.ToDateTime(R["ExpirationDate"])).ToString();
                labCreatedBy.Text = R["UserName"].ToString();
            }


        }

    }
}
