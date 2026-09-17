using BussinessLogicLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class frmManageUsers : Form
    {
        int selectedRowIndex = -1;
        public frmManageUsers()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0; // none is the default 
            tbSearchBy.Visible = false;
        }

        private void RefreshDataGridView()
        {
            DataTable dt = clsUsers.GetAllUsers();
            if (dt != null && dt.Rows.Count > 0)
            {
                this.DGVUsers.DataSource = dt;
                this.labCountOfRecords.Text = DGVUsers.Rows.Count.ToString();
            }
            else
            {
                DGVUsers.DataSource = null;
                this.labCountOfRecords.Text = "0";
            }


        }



        void SearchBySelectedFilter(string SearchKeyword) // this method will handle the search by selected filter
        {
 
            switch (cbFilter.SelectedItem)
            {
                case "PersonID":

                    if (int.TryParse(SearchKeyword, out int id))
                    {
                        DGVUsers.DataSource = clsUsers.FindUserByPersonID(id);
                    }
                    break;

                case "UserID":
                    if (int.TryParse(SearchKeyword, out int userId))
                    {
                        DGVUsers.DataSource = clsUsers.FindUserByUserID(userId);
                    }
                    break;

                case "Username":
                    DGVUsers.DataSource = clsUsers.FindUserByUserName(SearchKeyword);
                    break;

                case "FullName":
                    DGVUsers.DataSource = clsUsers.GetUsersByPersonFullName(SearchKeyword);
                    break;

                case "IsActive":
                    {
                        this.cbActiveFilter.Visible = true;
                        this.tbSearchBy.Visible = false;
                        /*
                         All
                        Yes
                          No
                         */
                        if (this.cbActiveFilter.SelectedItem == "All")
                        {
                            DGVUsers.DataSource = clsUsers.GetAllUsers();
                        }

                        if (this.cbActiveFilter.SelectedItem == "Yes")
                        {
                            DGVUsers.DataSource = clsUsers.GetAllActiveUsers();
                        }

                        if (this.cbFilter.SelectedItem == "No")
                        {
                            DGVUsers.DataSource = clsUsers.GetAllNONActiveUsers();
                        }

                    }
                    break;

            }

        }

        // changing the filter handling only
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex != -1 && cbFilter.SelectedItem != null && cbFilter.SelectedIndex != 0 && cbFilter.SelectedItem != "IsActive")
            {
                tbSearchBy.Visible = true;
                cbActiveFilter.Visible = false;
            }
            else if (cbFilter.SelectedIndex == 0) // if i set the filter to null 
            {
                tbSearchBy.Visible = false;
                cbActiveFilter.Visible = false;
                this.tbSearchBy.Text = string.Empty;
                RefreshDataGridView();
            }
            else if (cbFilter.SelectedItem == "IsActive")
            {
                tbSearchBy.Visible = false;
                cbActiveFilter.Visible = true;
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


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        
    }
}
