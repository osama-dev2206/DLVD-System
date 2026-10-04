using BussinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace FrontEnd
{
    public partial class frnManageInternationalLicensesApps : Form
    {
        public frnManageInternationalLicensesApps()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        int selectedRowIndex = -1; // this will hold the selected row index of the datagridview
        private void RefreshDataGridView()
        {
            DataTable dt = clsInternationalLicense.GetAll_InternatioanlLicensesApps();
            if (dt != null && dt.Rows.Count > 0)
            {
                this.DgvInternational.DataSource = dt;
                this.labCountOfRecords.Text = DgvInternational.Rows.Count.ToString();
            }
            else
            {
                DgvInternational.DataSource = null;
                this.labCountOfRecords.Text = "0";
            }


        }

        void SearchBySelectedFilter(string SearchKeyword) // this method will handle the search by selected filter
        {

            switch (cbFilter.SelectedItem)
            {
                case "ApplicationID":

                    if (int.TryParse(SearchKeyword, out int id))
                    {
                        DgvInternational.DataSource = clsInternationalLicense.GetLicAppByAppID(id);
                    }
                    break;

                case "DriverID":
                    if (int.TryParse(SearchKeyword, out int DriverId)) 
                    { 
                        DgvInternational.DataSource = clsInternationalLicense.GetLicAppByDriverID(DriverId);
                      }
                 break;

                case "LicenseID":
                    if(int.TryParse(SearchKeyword, out int LicenseId))
                    {
                        DgvInternational.DataSource = clsInternationalLicense.GetLicAppByLicenseID(LicenseId);
                    }
                    break;

                case "InternationalLicenseID":
                    if(int.TryParse(SearchKeyword, out int InternationalLicenseId))
                    {
                        DgvInternational.DataSource = clsInternationalLicense.GetLicAppByInternationalLicenseID(InternationalLicenseId);
                    }
                    break;
            }

        }


        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearchBy.Text = String.Empty; // as you have changed the filter 
            if (cbFilter.SelectedIndex != -1 && cbFilter.SelectedItem != null && cbFilter.SelectedIndex != 0)
            {
                tbSearchBy.Visible = true;
            }
            else if (cbFilter.SelectedIndex == 0) // if i set the filter to none 
            {
                tbSearchBy.Visible = false;
                this.tbSearchBy.Text = string.Empty;
                RefreshDataGridView();
            }

        }

        // International Driving License Applications DataGridView Selection Changed Event
        int ApplicantPersonID = -1;
        private void DGVInternationalSelectionChanged(object sender, EventArgs e) // --> cell[3] is Licnese Id (local)
        {
            if (this.DgvInternational.CurrentRow != null && DgvInternational.CurrentRow.Cells != null && int.TryParse(DgvInternational.CurrentRow.Cells[3]?.Value?.ToString(), out int RowIndex))
            {
                selectedRowIndex = RowIndex; 
                ApplicantPersonID = clsApplications.GetApplicationObjByAppID(Convert.ToInt32(DgvInternational.CurrentRow.Cells[1].Value)).ApplicantPersonID;
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
            // Allow only digits and control characters (like backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbAddNew_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicense frmNewInternationalLicense = new frmNewInternationalLicense();
            frmNewInternationalLicense?.ShowDialog();
            frmNewInternationalLicense?.Dispose();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowInternationalLicenseInfo frmShowInternationalLicenseInfo = new(LicenseID: selectedRowIndex);
            frmShowInternationalLicenseInfo?.ShowDialog();
            frmShowInternationalLicenseInfo?.Dispose();
        }

        private void showLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseHistory licenseHistory = new frmLicenseHistory(ApplicantPersonID: ApplicantPersonID);
            licenseHistory?.ShowDialog();
            licenseHistory?.Dispose();
        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowPersonDetails frmShowPerson = new FrmShowPersonDetails(PersonID: ApplicantPersonID);
            frmShowPerson?.ShowDialog();
            frmShowPerson?.Dispose();
        }


    }
}
