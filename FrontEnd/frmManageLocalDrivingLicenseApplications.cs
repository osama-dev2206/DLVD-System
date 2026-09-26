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
    public partial class frmManageLocalDrivingLicenseApplications : Form
    {
        int selectedRowIndex = -1;
        public frmManageLocalDrivingLicenseApplications()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void frmManageLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0; // none is the default 
            tbSearchBy.Visible = false;
            this.cbStatus.Visible = false;
        }

        private void RefreshDataGridView()
        {
            DataTable dt = clsLocalDrivingLicenseApplications.GetAllLocalApps();
            if (dt != null && dt.Rows.Count > 0)
            {
                this.DgvLocal.DataSource = dt;
                this.labCountOfRecords.Text = DgvLocal.Rows.Count.ToString();
            }
            else
            {
                DgvLocal.DataSource = null;
                this.labCountOfRecords.Text = "0";
            }


        }


        void SearchBySelectedFilter(string SearchKeyword) // this method will handle the search by selected filter
        {

            switch (cbFilter.SelectedItem)
            {
                case "L.D.L App ID":

                    if (int.TryParse(SearchKeyword, out int id))
                    {
                        DgvLocal.DataSource = clsLocalDrivingLicenseApplications.GetLocalAppsByLocalDrivingLicenseApplicationID(id);
                    }
                    break;

                case "National No":
                    DgvLocal.DataSource = clsLocalDrivingLicenseApplications.GetLocalAppsByNationalNo(SearchKeyword);
                    break;

                case "Full Name":
                    DgvLocal.DataSource = clsLocalDrivingLicenseApplications.GetLocalAppsByFullName(SearchKeyword);
                    break;
            }

        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbStatus.SelectedItem == "New")
            {
                DgvLocal.DataSource = clsLocalDrivingLicenseApplications.GetLocalAppsByNewStatus();
            }
            else if (cbStatus.SelectedItem == "Cancelled")
            {
                DgvLocal.DataSource = clsLocalDrivingLicenseApplications.GetLocalAppsByCancelledStatus();
            }
            else if (cbStatus.SelectedItem == "Completed")
            {
                DgvLocal.DataSource = clsLocalDrivingLicenseApplications.GetLocalAppsByCompletedStatus();
            }

        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearchBy.Text = String.Empty; // as you have changed the filter 
            if (cbFilter.SelectedIndex != -1 && cbFilter.SelectedItem != null && cbFilter.SelectedIndex != 0 && cbFilter.SelectedItem != "Status")
            {
                tbSearchBy.Visible = true;
                cbStatus.Visible = false;
            }
            else if (cbFilter.SelectedIndex == 0) // if i set the filter to none 
            {
                tbSearchBy.Visible = false;
                cbStatus.Visible = false;
                this.tbSearchBy.Text = string.Empty;
                RefreshDataGridView();
            }
            else if (cbFilter.SelectedItem == "Status")
            {
                this.tbSearchBy.Text = string.Empty;
                tbSearchBy.Visible = false;
                cbStatus.Visible = true;
            }

        }

        void CheckScheduleTestForSelectedApplication()//this function will handle the enabling and disabling of the schedule test menu items based on the status of the tests for the selected application
        {

            // if the applicatioin status is cancelled then we will disable all the schedule test menu items
            if (clsLocalDrivingLicenseApplications.GetApplicationStatusByLocalLicenseApplicationID(this.selectedRowIndex)  == clsApplications.enApplicationStatus.Cancelled)
            {
                this.scheduleVisionTestToolStripMenuItem.Enabled = false;
                this.ScheduleWrittenToolStripMenuItem.Enabled = false;
                this.ScheduleStreetToolStripMenuItem.Enabled = false;
                return;
            }

            if (!clsCheckTests.CheckIfVisionTestHasCompletedOrNot(selectedRowIndex)) // if vision test has not been completed then we can schedule the test 
            {
                this.scheduleVisionTestToolStripMenuItem.Enabled = true;
                this.ScheduleWrittenToolStripMenuItem.Enabled = false;
                this.ScheduleStreetToolStripMenuItem.Enabled = false;
            }
            else // Vision Test Has been completed so we can schedule the written test 
            {
                this.scheduleVisionTestToolStripMenuItem.Enabled = false;
                this.ScheduleWrittenToolStripMenuItem.Enabled = true; // enable the written test scheduling
                this.ScheduleStreetToolStripMenuItem.Enabled = false;
            }

            if (clsCheckTests.CheckIfWrittenTestHasCompletedOrNot(selectedRowIndex)) // if written test has not been completed then we can schedule the test 
            {
                this.ScheduleWrittenToolStripMenuItem.Enabled = false; // as the written has completed 
                this.ScheduleStreetToolStripMenuItem.Enabled = true;
            }
            if (clsCheckTests.CheckIfStreetTestHasCompletedOrNot(selectedRowIndex)) // if street test has not been completed then we can schedule the test 
            {
                this.ScheduleStreetToolStripMenuItem.Enabled = false; // as the street test has completed 
            }

        }

        private void DGVLocalSelectionChanged(object sender, EventArgs e)
        {
            if (this.DgvLocal.CurrentRow != null && DgvLocal.CurrentRow.Cells != null && int.TryParse(DgvLocal.CurrentRow.Cells[0]?.Value?.ToString(), out int Row))
            {
                selectedRowIndex = Row;
                CheckScheduleTestForSelectedApplication();
            }
        }

        private void tbSearchBy_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbSearchBy.Text))
            {
                SearchBySelectedFilter(tbSearchBy.Text);
            }

            else if (tbSearchBy.Visible) // if it is visible then the user has cleared the search box so we rest the view to default 
            {
                RefreshDataGridView(); // rest the dgv after clearing the search box 
            }
        }

        private void tbSearchBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedItem == "L.D.L App ID")
            {
                // Allow only digits and control characters (like backspace)
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Ignore the input
                }
            }
            else if (cbFilter.SelectedItem == "Full Name")
            {
                if (!char.IsLetter(e.KeyChar) &&
       !char.IsControl(e.KeyChar) &&
       !char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // CURD 
        void AddNewLocalDrivingLicenseApplication()
        {
            frmAddEditLocalDrivingLicense frm = new frmAddEditLocalDrivingLicense(-1);
            frm.ShowDialog();
            frm.Dispose();
            RefreshDataGridView();
        }
        private void pbAddNew_Click(object sender, EventArgs e)
        {
            AddNewLocalDrivingLicenseApplication();
        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditLocalDrivingLicense frmEdit = new frmAddEditLocalDrivingLicense(selectedRowIndex);
            frmEdit?.ShowDialog();
            frmEdit?.Dispose();
            RefreshDataGridView();
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsLocalDrivingLicenseApplications.Delete(selectedRowIndex))
            {
                MessageBox.Show("Application deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Failed to delete the application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void CancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplications.UpdateApplicationStatusUsingLocalDrivingLicID(selectedRowIndex, clsApplications.enApplicationStatus.Cancelled);
            RefreshDataGridView();
        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowLocalDrivingLicApplicationDetails frmShowLocalDriving = new frmShowLocalDrivingLicApplicationDetails(this.selectedRowIndex);
            frmShowLocalDriving?.ShowDialog();
            frmShowLocalDriving?.Dispose();
        }

        // Tests Scheduling .. ................ 
        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e) // add 
        {
            frmTestVisionAppointments frmTestVision = new frmTestVisionAppointments(this.selectedRowIndex,frmTestVisionAppointments.enMode.Add);
            frmTestVision?.ShowDialog();
            frmTestVision?.Dispose();
            RefreshDataGridView();
        }


    }
}
