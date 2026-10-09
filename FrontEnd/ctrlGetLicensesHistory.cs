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
    public partial class ctrlGetLicensesHistory : UserControl
    {
        public ctrlGetLicensesHistory()
        {
            InitializeComponent();
        }

        void LocalLicenseView(int ApplicantID)
        {
            this.DgvLocal.DataSource = clsLicenses.GetAllLicenseByApplicantID(ApplicantID);
            this.labCountOfRecordsLocal.Text = this.DgvLocal.Rows.Count.ToString();
        }

        void InternationalLicenseView(int ApplicantID)
        {
            this.DgvInternational.DataSource = clsInternationalLicense.GetInternationalLicenseDataView(ApplicantID);  // ApplicantID is the same as PersonID in this case
            this.labCountOfRecordsInternational.Text = this.DgvInternational.Rows.Count.ToString();
        }

        public void FillLicensesHistory(int ApplicantID)
        {
            LocalLicenseView(ApplicantID);
            InternationalLicenseView(ApplicantID);
        }


        int SelectedRow = -1;
        private enum enLicenseType { Local = 1, International = 2 }
        enLicenseType licenseType;

        private void DgvLocal_SelectionChanged(object sender, EventArgs e)
        {
            if (this.DgvLocal.CurrentRow != null && DgvLocal.CurrentRow.Cells != null && int.TryParse(DgvLocal.CurrentRow.Cells[1]?.Value?.ToString(), out int Row))
            {
                SelectedRow = Row;
                licenseType = enLicenseType.Local;
            }
        }

        private void DgvInternational_SelectionChanged(object sender, EventArgs e)
        {
            if (this.DgvInternational.CurrentRow != null && DgvInternational.CurrentRow.Cells != null && int.TryParse(DgvInternational.CurrentRow.Cells[2]?.Value?.ToString(), out int Row))
            {
                licenseType = enLicenseType.International;
                SelectedRow = Row;
            }
        }

        private void ShowLicensetoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (SelectedRow == -1)
            {
                MessageBox.Show("Error: Please select a license record to view.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (licenseType == enLicenseType.Local)
            {
                frmShowLicense showLicense = new frmShowLicense(MainApplicaionID: SelectedRow);

                showLicense?.ShowDialog();
                showLicense?.Dispose();
            }

            else if (licenseType == enLicenseType.International)
            {
                frmShowInternationalLicenseInfo frmShowInternationalLicense = new frmShowInternationalLicenseInfo(LicenseID: SelectedRow);
                frmShowInternationalLicense?.ShowDialog();
                frmShowInternationalLicense?.Dispose();
            }

        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e) // to avoid the selected row to be kept when switching between tabs
        {
            this.SelectedRow = -1; 
        }


    }
}
