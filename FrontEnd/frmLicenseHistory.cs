using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class frmLicenseHistory : Form
    {
        public frmLicenseHistory(int ApplicantPersonID)
        {
            InitializeComponent();
            this.ctrlPersonInfo1.LoadInfoUsingPersonID(ApplicantPersonID);
            this.ctrlGetLicensesHistory1.FillLicensesHistory(ApplicantPersonID);
            ctrlGetLicensesHistory1.OnLicIDSelection += CtrlGetLicensesHistory1_OnLicIDSelection;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        int selectedRowIndex = -1;
        void CtrlGetLicensesHistory1_OnLicIDSelection(int Row)
        {
            selectedRowIndex = Row;
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowLicense showLicense = new frmShowLicense(MainApplicaionID: selectedRowIndex);
            showLicense.ShowDialog();
            showLicense.Dispose();
        }
    }
}
