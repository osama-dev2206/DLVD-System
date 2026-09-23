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
        public frmManageLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        private void frmManageLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0; // none is the default 
            tbSearchBy.Visible = false;
        }

        private void RefreshDataGridView()
        {
            DataTable dt =
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



  
    }
}
