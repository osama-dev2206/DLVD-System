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
    public partial class frmAddNewAppointment : Form
    {
        clsVisionTests? visionTest;
        public enum enMode { Add = 1, Update = 2 }
        public frmAddNewAppointment(int LocalDrivingLicenseApplication, enMode mode)
        {
            InitializeComponent();
            this.ctrlScheduleTestInfo1.FillCtrlInfoByLocalDrivingApplicationID(LocalDrivingLicenseApplication, BussinessLogicLayer.clsTestTypes.enTestTypes.VisionTest);
            ctrlScheduleTestInfo1.OnDateTimeSelected += VisionTest_DateTimeChanger;

            if (mode == enMode.Add)
            {
                visionTest = new clsVisionTests(LocalDrivingLicenseApplication); /// Add New 
                visionTest.OnSaveGetError += OnSaveGetError;
            }
        }

        void VisionTest_DateTimeChanger(DateTime DT)
        {
            visionTest?.AppointmentDateTime = DT;
        }

        void OnSaveGetError(string ErrorMessage)
        {
            MessageBox.Show(ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (visionTest.Save()) //add new appointment
            {
                MessageBox.Show("Vision Test Appointment Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
   
    
    }
}
