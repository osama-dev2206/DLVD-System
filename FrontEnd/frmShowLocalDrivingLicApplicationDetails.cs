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
        int LApplicationID;
        string ClassName;
        int LocalApplicationID;
        public frmShowLocalDrivingLicApplicationDetails(int LocalApplicationID) { 
           
            this. LocalApplicationID= LocalApplicationID;
            InitializeComponent();
           clsLocalDrivingLicenseApplications.GetBasicInfoOfLocalLicenseApplication(LocalAppID:LocalApplicationID , out  LApplicationID , out  ClassName);
            FillFormInfo();
        }


        private void FillFormInfo()
        {
            this.ctrlApplicationInfo1.FillCtrlInfo(this.LApplicationID);
            this.labClassName.Text = this.ClassName;
            this.labLocalAppId.Text = LocalApplicationID.ToString();
        }

        


    }
}
