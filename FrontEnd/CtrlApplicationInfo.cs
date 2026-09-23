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
    public partial class CtrlApplicationInfo : UserControl
    {
        public CtrlApplicationInfo()
        {
            InitializeComponent();
        }

        public CtrlApplicationInfo(int ApplicationID)
        {
            if (!int.TryParse(ApplicationID.ToString(), out int appID) || appID <= 0)
            {
                this?.Dispose();
            }

            InitializeComponent();
            FillCtrlInfo(ApplicantPersonID);
        }

        int ApplicantPersonID = -1;
        public void FillCtrlInfo(int ApplicationID)
        {
            DataTable dt;
            if ((dt = clsApplications.GetApplicationObjDetailsByApplicationID(ApplicationID)) is not null)
            {
                foreach (DataRow R in dt.Rows)
                {
                    this.labApplicationID.Text = R["ApplicationID"].ToString();
                    this.ApplicantPersonID = Convert.ToInt32(R["ApplicantPersonID"]);
                    this.labApplicationDT.Text = (R["ApplicationDateTime"]).ToString();
                    this.labApplicationType.Text = R["ApplicationType"].ToString();
                    this.labApplicationStatus.Text = R["ApplicationStatus"].ToString();
                    this.labLastDT.Text = R["LastStatusDateTime"].ToString();
                    this.labPaidFees.Text = R["PaidFees"].ToString();
                    this.labCreatedBy.Text = R["CreatedByUserName"].ToString();

                    break;
                }

            }
            else
            {
                MessageBox.Show("Falied To Get Info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labApplicantPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmShowPersonDetails frmShowPerson = new FrmShowPersonDetails(ApplicantPersonID);
            frmShowPerson?.ShowDialog();
            frmShowPerson?.Dispose();
        }



    }
}
