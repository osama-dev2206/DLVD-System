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
    public partial class frmAddEditAppointment : Form
    {
        clsVisionTests? visionTest;
        clsWrittenTest ? writtenTest;
        clsTestTypes.enTestTypes testType;

        public enum enMode { Add = 1, Update = 2 }
        public frmAddEditAppointment(int LocalDrivingLicenseApplication, clsTestTypes.enTestTypes testType, int AppointmentID = -1, enMode mode = enMode.Add)
        {

            InitializeComponent();
            this.testType = testType;
            this.ctrlRetakeTestInfo1.Enabled = false;
             
            if (testType == clsTestTypes.enTestTypes.VisionTest)
            {
                this.ctrlScheduleTestInfo1.FillCtrlInfoByLocalDrivingApplicationID(LocalDrivingLicenseApplication, BussinessLogicLayer.clsTestTypes.enTestTypes.VisionTest);
                ctrlScheduleTestInfo1.OnDateTimeSelected += DateTimeChanger;
            }
            else if (testType == clsTestTypes.enTestTypes.WrittenTest)
            {
                this.ctrlScheduleTestInfo1.FillCtrlInfoByLocalDrivingApplicationID(LocalDrivingLicenseApplication, BussinessLogicLayer.clsTestTypes.enTestTypes.WrittenTest);
                ctrlScheduleTestInfo1.OnDateTimeSelected += DateTimeChanger;
            }
            else if (testType == clsTestTypes.enTestTypes.PracticalTest)
            {
                // Later
            }



            if (mode == enMode.Add)
            {
                if (clsTestTypes.enTestTypes.VisionTest == testType)
                {
                    visionTest = new clsVisionTests(LocalDrivingLicenseApplication); /// Add New 
                    visionTest.OnSaveGetTheRetakeID += UpdateTheRApplicationIDOnCtrlRetakeTestInfo; // on the add only (reschedule retake test)
                    visionTest.OnSaveGetError += OnSaveGetError;
                }

                else if (clsTestTypes.enTestTypes.WrittenTest == testType)
                {
                    writtenTest = new clsWrittenTest(LocalDrivingLicenseApplication); /// Add New 
                    writtenTest.OnSaveGetTheRetakeID += UpdateTheRApplicationIDOnCtrlRetakeTestInfo; // on the add only (reschedule retake test)
                    writtenTest.OnSaveGetError += OnSaveGetError;
                }
                else if (clsTestTypes.enTestTypes.PracticalTest == testType)
                {
                    // Later
                }


            }

            else if (mode == enMode.Update && AppointmentID != -1)
            {
                if (clsTestTypes.enTestTypes.VisionTest == testType)
                {
                    visionTest = clsVisionTests.GetVisionTestAppointmentByAppointmentID(AppointmentID); /// Update Existing
                    visionTest.OnSaveGetError += OnSaveGetError;
                    this.ctrlScheduleTestInfo1.FillCtrlInfoByLocalDrivingApplicationID(LocalDrivingLicenseApplicationID: LocalDrivingLicenseApplication, BussinessLogicLayer.clsTestTypes.enTestTypes.VisionTest);
                }
                else if (clsTestTypes.enTestTypes.WrittenTest == testType)
                {
                    writtenTest = clsWrittenTest.GetWrittenTestAppointmentByAppointmentID(AppointmentID); /// Update Existing
                    writtenTest.OnSaveGetError += OnSaveGetError;
                    this.ctrlScheduleTestInfo1.FillCtrlInfoByLocalDrivingApplicationID(LocalDrivingLicenseApplicationID: LocalDrivingLicenseApplication, BussinessLogicLayer.clsTestTypes.enTestTypes.WrittenTest);
                }
                else if (clsTestTypes.enTestTypes.PracticalTest == testType)
                {
                    // Later
                }

            }

            bool? res = null;

            if (clsTestTypes.enTestTypes.VisionTest == testType)
            {
                res = !clsTest.IsAplicantSuccessedBefore(LocalDrivingLicenseApplication, (int)BussinessLogicLayer.clsTestTypes.enTestTypes.VisionTest); // Has Failed Before
            }

            else if (clsTestTypes.enTestTypes.WrittenTest == testType)
            {
                res = !clsTest.IsAplicantSuccessedBefore(LocalDrivingLicenseApplication, (int)BussinessLogicLayer.clsTestTypes.enTestTypes.WrittenTest); // Has Failed Before
            }

            else if (clsTestTypes.enTestTypes.PracticalTest == testType)
            {
                // Later
            }

            if (res == true)
            {
                this.labFormStatus.Text = "Retake Schedule Test";
                this.ctrlRetakeTestInfo1.Enabled = true;
                if (clsTestTypes.enTestTypes.VisionTest == testType)
                {
                    this.ctrlRetakeTestInfo1.Filll_Initial_CtrlInfoByLocalDrivingApplicationID(LocalDrivingLicenseApplication, BussinessLogicLayer.clsTestTypes.enTestTypes.VisionTest);
                }

                else if (clsTestTypes.enTestTypes.WrittenTest == testType)
                {
                    this.ctrlRetakeTestInfo1.Filll_Initial_CtrlInfoByLocalDrivingApplicationID(LocalDrivingLicenseApplication, BussinessLogicLayer.clsTestTypes.enTestTypes.WrittenTest);
                }

                else if (clsTestTypes.enTestTypes.PracticalTest == testType)
                {
                    // Later
                }

            }


        }


        void DateTimeChanger(DateTime DT)
        {
            if (clsTestTypes.enTestTypes.VisionTest == testType)
            {
                visionTest?.AppointmentDateTime = DT;
            }
            else if (clsTestTypes.enTestTypes.WrittenTest == testType)
            {
                writtenTest?.AppointmentDateTime = DT;
            }
            else if (clsTestTypes.enTestTypes.PracticalTest == testType)
            {
                // Later
            }

        }

          void OnSaveGetError(string ErrorMessage)
        {
            MessageBox.Show(ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void UpdateTheRApplicationIDOnCtrlRetakeTestInfo(int RetakeID)
        {
            this.ctrlRetakeTestInfo1.UpdateRetakeIDApplicationID(RetakeID);
        }

        private void btnSave_Click(object sender, EventArgs e) {

            switch (this.testType)
            {

                case clsTestTypes.enTestTypes.VisionTest:
                    {

                        if (visionTest.AppointmentDateTime == null || visionTest.AppointmentDateTime == default)
                        {
                            MessageBox.Show("Vision Test Appointment Error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (visionTest.Save()) //add new appointment
                        {
                            MessageBox.Show("Vision Test Appointment Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }

                case clsTestTypes.enTestTypes.WrittenTest:
                    {
                        if (writtenTest.AppointmentDateTime == null || writtenTest.AppointmentDateTime == default)
                        {
                            MessageBox.Show("Written Test Appointment Error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (writtenTest.Save()) //add new appointment
                        {
                            MessageBox.Show("Written Test Appointment Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }

                case clsTestTypes.enTestTypes.PracticalTest:
                    {
                        // Later
                        break;

                    }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
   
    
    }
}
