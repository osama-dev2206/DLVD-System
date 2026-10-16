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
    public partial class frmManageDetainedLicenses : Form
    {
        int selectedRowIndex = -1;
        public frmManageDetainedLicenses()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void frmManageDetainedLicenses_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0; // none is the default 
            tbSearchBy.Visible = false;
        }

        private void RefreshDataGridView()
        {
            DataTable dt = clsDetainReleaseLicense.GetAllDetainedLicenses();
            if (dt != null && dt.Rows.Count > 0)
            {
                this.DgvLicenses.DataSource = dt;
                this.labCountOfRecords.Text = DgvLicenses.Rows.Count.ToString();
            }
            else
            {
                DgvLicenses.DataSource = null;
                this.labCountOfRecords.Text = "0";
            }


        }

        /*
         None
DetainID
IsReleased
NationalNo
FullName
ReleaseAppID
         */
        void SearchBySelectedFilter(string SearchKeyword) // this method will handle the search by selected filter
        {

            switch (cbFilter.SelectedItem)
            {
                case "DetainID":

                    if (int.TryParse(SearchKeyword, out int id))
                    {
                        
                    }
                    break;

                case "IsReleased":
                    
                    break;

                case "NationalNo":
                
                    break;

                case "FullName":
                    break;

                    case "ReleaseAppID":
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
            else if (cbFilter.SelectedItem == "IsReleased")
            {
                tbSearchBy.Visible = false;
            }
            else if (cbFilter.SelectedIndex == 0) // if i set the filter to none 
            {
                tbSearchBy.Visible = false;

                this.tbSearchBy.Text = string.Empty;
                RefreshDataGridView();
            }

            }

        


        //  Driving License Applications DataGridView Selection Changed Event
        private void DGVLicSelectionChanged(object sender, EventArgs e)
        {
            if (this.DgvLicenses.CurrentRow != null && DgvLicenses.CurrentRow.Cells != null && int.TryParse(DgvLicenses.CurrentRow.Cells[0]?.Value?.ToString(), out int Row))
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

        private void tbSearchBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedItem == "DetainID" || cbFilter.SelectedItem == "ReleaseAppID")
            {
                // Allow only digits and control characters (like backspace)
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Ignore the input
                }
            }
            else if (cbFilter.SelectedItem == "FullName" || cbFilter.SelectedItem == "NationalNo")
            {
                if (!char.IsLetter(e.KeyChar) &&
       !char.IsControl(e.KeyChar) &&
       !char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
