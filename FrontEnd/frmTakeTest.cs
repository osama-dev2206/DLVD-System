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
    public partial class frmTakeTest : Form
    {
        clsTest test;
        public frmTakeTest(int AppointmentID, int LDLAPPID)
        {
            InitializeComponent();
            this.ctrlScheduleTestInfo1.FillCtrlInfoByLocalDrivingApplicationID(LDLAPPID, BussinessLogicLayer.clsTestTypes.enTestTypes.VisionTest);

            test = new clsTest(AppointmentID);
            test.OnTestSaveGetTestID += UpdateTestIdLabel;
        }

        private void rb_Click(object sender, EventArgs e)
        {
            if (rbPass.Checked)
            {
                this.test.TestResult = 1;
            }
            else if (rbFail.Checked)
            {
                this.test.TestResult = 0;
            }
        }

        private void Notes_TextChanged(object sender, EventArgs e)
        {
            this.test.Notes = this.txtNotes.Text;
        }

        void UpdateTestIdLabel(int ID)
        {
            this.labTestID.Text = ID.ToString();
        }

        bool CheckBeforeSave()
        {
            if (this.test.TestResult != 1 && this.test.TestResult != 0)
            {
                MessageBox.Show("Please select Test Result (Pass/Fail)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckBeforeSave())
            {
                if(test.Save())
                {
                    MessageBox.Show("Test Result Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error Saving Test Result", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Fill Correct Info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
    
    }
}
