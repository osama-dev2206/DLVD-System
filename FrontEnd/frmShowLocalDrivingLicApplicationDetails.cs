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
    public partial class frmShowLocalDrivingLicApplicationDetails : Form
    {

        public frmShowLocalDrivingLicApplicationDetails(int LocalApplicationID)
        {

            InitializeComponent();

            FillFormInfo( LocalApplicationID);
        }


        private void FillFormInfo(int LocalApplicationID)
        {
            this.ctrlApplicationInfo1.FillCtrlInfoByLocalDrivingApplicationID(LocalApplicationID);
             this.ctrlLcoalDrivingLicenseInfo1.FillForm(LocalApplicationID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
