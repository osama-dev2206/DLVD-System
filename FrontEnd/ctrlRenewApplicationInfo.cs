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
    public partial class ctrlRenewApplicationInfo : UserControl
    {
        public ctrlRenewApplicationInfo()
        {
            InitializeComponent();
        }
        internal void FillForm(int NewLicenseID, int OldLicenseID = -1  ) 
        {
           DataTable dt = 
    clsRenewLicense.LicenseSummaryInfo(NewLicenseID);

            foreach (DataRow dr in dt.Rows)
            {
                labNewLicID.Text = dr["LicenseID"].ToString();
                labOldLicID.Text = (OldLicenseID == -1) ? "N/A" : OldLicenseID.ToString();
                labLicFees.Text = dr["LicenseFees"].ToString();
                labExpDate.Text = DateOnly.FromDateTime(Convert.ToDateTime(dr["ExpirationDate"])).ToString();
                labIssueDate.Text  = DateOnly.FromDateTime(Convert.ToDateTime(dr["IssueDate"])).ToString();
                labTotalFees.Text = dr["TotalFees"].ToString();
                break;
            }


        }

    }
}
