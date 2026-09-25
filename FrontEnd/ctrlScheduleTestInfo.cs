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
    public partial class ctrlScheduleTestInfo : UserControl
    {

        public ctrlScheduleTestInfo( )
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Now;
        }

        public ctrlScheduleTestInfo(int LocalDrivingLicenseApplicationID , clsTestTypes.enTestTypes testType)
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Now;
            FillCtrlInfoByLocalDrivingApplicationID(LocalDrivingLicenseApplicationID, testType);
        }


        public void FillCtrlInfoByLocalDrivingApplicationID(int LocalDrivingLicenseApplicationID, clsTestTypes.enTestTypes testType)
        {

            clsLocalDrivingLicenseApplications.GetBasicInfoOfLocalLicenseApplication(LocalDrivingLicenseApplicationID, out int LApplicationID, out string ClassName);
            this.labAppID.Text = LocalDrivingLicenseApplicationID.ToString();
            this.labClassName.Text = ClassName;

            var Person = clsPeople.GetPersonObjectByPersonID(clsApplications.GetApplicationObjByAppID(LApplicationID).ApplicantPersonID);

            this.labName.Text = Person.FirstName + " " + Person.SecondName +  " " + Person.LastName;

            if (testType == clsTestTypes.enTestTypes.VisionTest)
            {
                this.labFees.Text = clsTestTypes.FindTestType((int)clsTestTypes.enTestTypes.VisionTest).TestTypeFee.ToString();

                this.labTrials.Text = clsVisionTests.GetNumOfTrialsOfVisionTest(LocalDrivingLicenseApplicationID).ToString();
            }
            else if(testType == clsTestTypes.enTestTypes.WrittenTest) 
            {
                this.labFees.Text = clsTestTypes.FindTestType((int)clsTestTypes.enTestTypes.WrittenTest).TestTypeFee.ToString();

                this.labTrials.Text ="Not Impelemented Yet Shitty";
            }
            else if(testType == clsTestTypes.enTestTypes.PracticalTest)
            {
                this.labFees.Text = clsTestTypes.FindTestType((int)clsTestTypes.enTestTypes.PracticalTest).TestTypeFee.ToString();
                this.labTrials.Text = "Not Impelemented Yet Shitty";
            }

        }




        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value > DateTime.Now)
            {
                OnDateTimeSelected?.Invoke( dateTimePicker1.Value);
            }
        }


        public Action<DateTime> OnDateTimeSelected;
    }
}
