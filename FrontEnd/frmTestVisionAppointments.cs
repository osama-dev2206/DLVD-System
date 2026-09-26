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
    public partial class frmTestVisionAppointments : Form
    {
        int LocalDrivingLicenseAppID;
       public enum enMode { Add = 1, Update = 2 }
        public frmTestVisionAppointments(int LocalDrivingLicense, enMode mode)
        {
            InitializeComponent();
            this.LocalDrivingLicenseAppID = LocalDrivingLicense;

            RefreshDataGridView();

            this.ctrlLocalDrivingLicenseInfo2.FillForm(LocalDrivingLicense);
            this.ctrlApplicationInfo1.FillCtrlInfoByLocalDrivingApplicationID(LocalDrivingLicense);


        }

        private void RefreshDataGridView() // Please Note The data will be related to the LocalDrivingLicenseAppID passed in the constructor of this form
        {
            DataTable dt = clsVisionTests.GetAllVisionTestAppointements(LocalDrivingLicenseAppID);
            if (dt != null && dt.Rows.Count > 0)
            {
                this.DgvVisionAppointments.DataSource = dt;
                this.labCountOfRecords.Text = DgvVisionAppointments.Rows.Count.ToString();
            }
            else
            {
                DgvVisionAppointments.DataSource = null;
                this.labCountOfRecords.Text = "0";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int selectedRowIndex = -1; // appointment ID of the selected row in the DataGridView
        private void DGVUsersSelectionChanged(object sender, EventArgs e)
        {
            if (this.DgvVisionAppointments.CurrentRow != null && DgvVisionAppointments.CurrentRow.Cells != null && int.TryParse(DgvVisionAppointments.CurrentRow.Cells[0]?.Value?.ToString(), out int Row))
            {
                selectedRowIndex = Row;
            }
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            frmAddEditAppointment frmAddNew = new frmAddEditAppointment(LocalDrivingLicenseAppID, -1,frmAddEditAppointment.enMode.Add);
            frmAddNew?.ShowDialog();
            frmAddNew?.Dispose();
            RefreshDataGridView();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // The Edit will be with appointment id 
            frmAddEditAppointment frmAddNew = 
           new frmAddEditAppointment(LocalDrivingLicenseApplication: LocalDrivingLicenseAppID, AppointmentID: selectedRowIndex ,  frmAddEditAppointment.enMode.Update);
            frmAddNew?.ShowDialog();
            frmAddNew?.Dispose();
            RefreshDataGridView();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTakeTest test = new frmTakeTest(LDLAPPID: this.LocalDrivingLicenseAppID, AppointmentID: selectedRowIndex);
            test?.ShowDialog(); 
            test?.Dispose();
            RefreshDataGridView();
            ctrlLocalDrivingLicenseInfo2.FillForm(LocalDrivingLicenseAppID); // refresh the local driving license info after taking the test
        }


    }
}
