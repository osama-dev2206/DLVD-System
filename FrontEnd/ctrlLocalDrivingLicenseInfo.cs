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
    public partial class ctrlLocalDrivingLicenseInfo : UserControl
    {
        public ctrlLocalDrivingLicenseInfo()
        {
            InitializeComponent();
        }

        public ctrlLocalDrivingLicenseInfo(int LocalAppID)
        {
            InitializeComponent();
            FillForm(LocalAppID);
        }

        public void FillForm(int LocalApplicationID)
        {
            clsLocalDrivingLicenseApplications.GetBasicInfoOfLocalLicenseApplication(LocalApplicationID, out int LApplicationID, out string ClassName);
            this.labAppID.Text = LocalApplicationID.ToString();
            this.labAppliedFor.Text = ClassName;
            this.labNumOfPassedTest.Text = clsLocalDrivingLicenseApplications.GetNumOfPassedTestsByLocalDrivingLicenseApplicationID(LocalApplicationID).ToString()+"/3";
        }


    }
}
