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
    public partial class frmManageWrittenTestAppointments : Form
    {
        int LocalDrivingLicenseAppID;

        public frmManageWrittenTestAppointments(int LocalDrivingLicense)
        {
            InitializeComponent();
            this.LocalDrivingLicenseAppID = LocalDrivingLicense;

            RefreshDataGridView();

            this.ctrlLocalDrivingLicenseInfo2.FillForm(LocalDrivingLicense);
            this.ctrlApplicationInfo1.FillCtrlInfoByLocalDrivingApplicationID(LocalDrivingLicense);
        }


        private void RefreshDataGridView() // Please Note The data will be related to the LocalDrivingLicenseAppID passed in the constructor of this form
        {
            DataTable dt = clsWrittenTest.GetAllWrittenTestAppointements(LocalDrivingLicenseAppID); // change
            if (dt != null && dt.Rows.Count > 0)
            {
                this.DgvWrittenAppointments.DataSource = dt;
                this.labCountOfRecords.Text = DgvWrittenAppointments.Rows.Count.ToString();
            }
            else
            {
                DgvWrittenAppointments.DataSource = null;
                this.labCountOfRecords.Text = "0";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int selectedRowIndex = -1; // appointment ID of the selected row in the DataGridView
        private void DGVAppointmentsSelectionChanged(object sender, EventArgs e)
        {
            if (this.DgvWrittenAppointments.CurrentRow != null && DgvWrittenAppointments.CurrentRow.Cells != null && int.TryParse(DgvWrittenAppointments.CurrentRow.Cells[0]?.Value?.ToString(), out int Row))
            {
                selectedRowIndex = Row;
            }
        }


        // Written Test Appointment Management: Add, Edit, Take Test
        private void pbAdd_Click(object sender, EventArgs e)
        {
            //int LocalDrivingLicenseApplication, clsTestTypes.enTestTypes testType, int AppointmentID = -1, enMode mode = enMode.Add
            frmAddEditAppointment frmAddNew = new frmAddEditAppointment(LocalDrivingLicenseAppID,  clsTestTypes.enTestTypes.WrittenTest, -1,frmAddEditAppointment.enMode.Add);
            frmAddNew?.ShowDialog();
            frmAddNew?.Dispose();
            RefreshDataGridView();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // The Edit will be with appointment id 
            frmAddEditAppointment frmAddNew =
           new frmAddEditAppointment(LocalDrivingLicenseApplication: LocalDrivingLicenseAppID, clsTestTypes.enTestTypes.WrittenTest,AppointmentID: selectedRowIndex, frmAddEditAppointment.enMode.Update);
            frmAddNew?.ShowDialog();
            frmAddNew?.Dispose();
            RefreshDataGridView();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmTakeTest test = new frmTakeTest(LDLAPPID: this.LocalDrivingLicenseAppID, AppointmentID: selectedRowIndex, testTypes: clsTestTypes.enTestTypes.WrittenTest);
            test?.ShowDialog();
            test?.Dispose();
            RefreshDataGridView();
            ctrlLocalDrivingLicenseInfo2.FillForm(LocalDrivingLicenseAppID); // refresh the local driving license info after taking the test
        }




    }
}
