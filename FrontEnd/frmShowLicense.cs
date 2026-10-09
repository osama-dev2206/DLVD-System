using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class frmShowLicense : Form
    {

        public frmShowLicense( int MainApplicaionID)
        {
            InitializeComponent();

            this.ctrlLicenseInfo1.FillForm(ApplicaionID: MainApplicaionID);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
