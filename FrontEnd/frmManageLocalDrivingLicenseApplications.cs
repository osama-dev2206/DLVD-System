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
                        DgvLocal.DataSource = clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplicationByLocalID(id);
                    }
                    break;

                case "National No":
                    DgvLocal.DataSource = clsLocalDrivingLicenseApplications.GetLocalAppsByNationalNo(SearchKeyword);
                    break;

                case "Full Name":
                    clsLocalDrivingLicenseApplications.GetLocalAppsByFullName(SearchKeyword);
                    break;
            }

        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbStatus.SelectedItem == "None")
            {
                RefreshDataGridView();
            }
            else if(cbStatus.SelectedItem == "New")
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
        /*
         None
L.D.L App ID
National No
Full Name
Status
         
         */

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex != -1 && cbFilter.SelectedItem != null && cbFilter.SelectedIndex != 0 && cbFilter.SelectedItem != "Status")
            {
                tbSearchBy.Visible = true;
                cbStatus.Visible = false;
            }
            else if (cbFilter.SelectedIndex == 0) // if i set the filter to null 
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

        private void DGVLocalSelectionChanged(object sender, EventArgs e)
        {
            if (this.DgvLocal.CurrentRow != null && DgvLocal.CurrentRow.Cells != null && int.TryParse(DgvLocal.CurrentRow.Cells[0]?.Value?.ToString(), out int Row))
            {
                selectedRowIndex = Row;
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


    }
}
