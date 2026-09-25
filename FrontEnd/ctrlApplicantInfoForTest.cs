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
    public partial class ctrlApplicantInfoForTest : UserControl
    {

        public ctrlApplicantInfoForTest( )
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Now;
        }

        public ctrlApplicantInfoForTest(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Now;
            FillCtrlInfoByLocalDrivingApplicationID(LocalDrivingLicenseApplicationID);
        }


        public void FillCtrlInfoByLocalDrivingApplicationID(int LocalDrivingLicenseApplicationID)
        {

            clsLocalDrivingLicenseApplications.GetBasicInfoOfLocalLicenseApplication(LocalDrivingLicenseApplicationID, out int LApplicationID, out string ClassName);
            this.labAppID.Text = LocalDrivingLicenseApplicationID.ToString();
            this.labClassName.Text = ClassName;

            var Person = clsPeople.GetPersonObjectByPersonID(clsApplications.GetApplicationObjByAppID(LApplicationID).ApplicantPersonID);

            this.labName.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;

            this.labFees.Text = clsTestTypes.FindTestType((int)clsTestTypes.enTestTypes.VisionTest).TestTypeFee.ToString();

            this.labTrials.Text = clsVisionTests.GetNumOfTrialsOfVisionTest(LocalDrivingLicenseApplicationID).ToString();
        }

        internal DateTime SelectedDateTime; 
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value > DateTime.Now)
            {
                SelectedDateTime = dateTimePicker1.Value;
            }
        }


    }
}
