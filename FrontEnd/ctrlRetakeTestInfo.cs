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
    public partial class ctrlRetakeTestInfo : UserControl
    {
        public ctrlRetakeTestInfo()
        {
            InitializeComponent();

            
        }

        internal void Filll_Initial_CtrlInfoByLocalDrivingApplicationID(int LocalDrivingLicenseAppID, clsTestTypes.enTestTypes  TestType)
        {
            this.labRetakeApplicationID.Text = "-1";
            decimal TestTypeFee = clsTestTypes.FindTestType((int)TestType).TestTypeFee;
            decimal LabApplicationFee = clsApplicationTypes.FindAppObjByAppID((int)clsApplicationTypes.enApplicationTypes.RetakeTest).ApplicationFees;
            decimal TotalApplicationFee = TestTypeFee + LabApplicationFee;

            this.labApplicationFees.Text = TestTypeFee.ToString("C2");
            this.labTotalFees.Text= TotalApplicationFee.ToString("C2");

            
        }
         internal void UpdateRetakeIDApplicationID(int RetakeID)
        {
            this.labRetakeApplicationID.Text = RetakeID.ToString();
        }

    }
}
