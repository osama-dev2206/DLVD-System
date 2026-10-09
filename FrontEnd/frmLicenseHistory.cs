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

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
