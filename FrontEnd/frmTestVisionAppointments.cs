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
        public frmTestVisionAppointments(int LocalDrivingLicense)
        {
            InitializeComponent();
            RefreshDataGridView();
            this.ctrlLocalDrivingLicenseInfo2.FillForm(LocalDrivingLicense);
            this.ctrlApplicationInfo1.FillCtrlInfoByLocalDrivingApplicationID(LocalDrivingLicense);
        }

        private void RefreshDataGridView()
        {
            DataTable dt = clsVisionTests.GetAllVisionTestAppointements();
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

        private void frmTestVisionAppointments_Load(object sender, EventArgs e)
        {

        }


    }
}
