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


        private void tbSearchBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedItem == "PersonID" || cbFilter.SelectedItem == "UserID")
            {
                // Allow only digits and control characters
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
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
                        DGVUsers.DataSource = clsUsers.FindBasicUserByUserID(userId);
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
                this.tbSearchBy.Text = string.Empty;
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

        private void DGVUsersSelectionChanged(object sender, EventArgs e)
        {
            if (DGVUsers.CurrentRow != null && DGVUsers.CurrentRow.Cells != null && int.TryParse(DGVUsers.CurrentRow.Cells[0]?.Value?.ToString(), out int Row))
            {
                selectedRowIndex = Row;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this person?", "Delete Person", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (clsUsers.DeleteUserByUserID(this.selectedRowIndex))
                {
                    MessageBox.Show("User deleted successfully.", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGridView();

                }
                else
                    MessageBox.Show("Failed to delete User (User maybe connected with another entity).", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void showDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex == -1) return;
            frmShowCurrentUserInfo frm = new frmShowCurrentUserInfo(UserID: this.selectedRowIndex, PersonID: clsUsers.FindUserByUserIDAsObj(selectedRowIndex).PersonID);
            frm.ShowDialog();
            frm.Dispose();
        }

        //Add
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Edit 
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
