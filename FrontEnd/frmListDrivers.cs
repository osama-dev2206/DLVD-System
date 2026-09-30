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
    public partial class frmListDrivers : Form
    {
        public frmListDrivers()
        {
     
            InitializeComponent();
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            DataTable dt = clsDrivers.ListDrivers();
            if (dt != null && dt.Rows.Count > 0)
            {
                this.DGVDrivers.DataSource = dt;
                this.labCountOfRecords.Text = DGVDrivers.Rows.Count.ToString();
            }
            else
            {
                DGVDrivers.DataSource = null;
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

            if (cbFilter.SelectedItem == "FullName")
            {
                // Allow only letters, digits, whitespace, and control characters
                if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

        }

        void SearchBySelectedFilter(string SearchKeyword) // this method will handle the search by selected filter
        {

            switch (cbFilter.SelectedItem)
            {
                case "Driver ID":

                    if (int.TryParse(SearchKeyword, out int id))
                    {
                     this.DGVDrivers.DataSource =  clsDrivers.FindDriverByDriverID(id);
                    }
                    break;

                case "Person ID":
                    if (int.TryParse(SearchKeyword, out int PersonId))
                    {
                        this.DGVDrivers.DataSource = clsDrivers.FindDriverByPersonID(PersonId);
                    }
                    break;

                case "National No":
                    this.DGVDrivers.DataSource = clsDrivers.FindDriverByNationalNo(SearchKeyword);
                    break;

                case "Full Name":
                    this.DGVDrivers.DataSource = clsDrivers.FindDriverByFullName(SearchKeyword);
                    break;



            }

        }

        // changing the filter handling only
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex != -1 && cbFilter.SelectedItem != null && cbFilter.SelectedIndex != 0)
            {
                tbSearchBy.Visible = true;

            }
            else if (cbFilter.SelectedIndex == 0) // if i set the filter to null 
            {
                tbSearchBy.Visible = false;
            
                this.tbSearchBy.Text = string.Empty;
                RefreshDataGridView();
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
