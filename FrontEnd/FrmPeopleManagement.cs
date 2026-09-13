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
    public partial class FrmPeopleManagement : Form
    {
        int selectedRowIndex = -1;

        public FrmPeopleManagement()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            DataTable dt = clsPeople.GetPeople();
            if (dt != null && dt.Rows.Count > 0)
            {
                this.DGVPeople.DataSource = dt;
            }
            else
            {
                DGVPeople.Rows.Clear();
            }
        }

        private void FrmPeopleManagement_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0; // none is the default 
            tbSearchBy.Visible = false;
            if (DGVPeople is not null) this.labCountOfRecords.Text = DGVPeople.Rows.Count.ToString();
        }


        void SearchBySelectedFilter(string SearchKeyword) // this method will handle the search by selected filter
        {

            switch (cbFilter.SelectedItem)
            {
                case "PersonID":
                    if (int.TryParse(SearchKeyword, out int id))
                    {
                        DGVPeople.DataSource = clsPeople.GetPersonByPersonID(id);
                    }
                    break;

                case "NationalNo":
                    DGVPeople.DataSource = clsPeople.GetPersonByNationalNo(SearchKeyword);
                    break;

                case "FirstName":
                    DGVPeople.DataSource = clsPeople.GetPersonByFirstName(SearchKeyword);
                    break;

                case "SecondName":
                    DGVPeople.DataSource = clsPeople.GetPersonBySecondName(SearchKeyword);
                    break;

                case "ThirdName":
                    DGVPeople.DataSource = clsPeople.GetPersonByThirdName(SearchKeyword);
                    break;

                case "LastName":
                    DGVPeople.DataSource = clsPeople.GetPersonByLastName(SearchKeyword);
                    break;

                case "Nationality":
                    DGVPeople.DataSource = clsPeople.GetPersonByNationality(SearchKeyword);
                    break;

                case "Gender":
                    DGVPeople.DataSource = clsPeople.GetPersonByGender(SearchKeyword);
                    break;

                case "Phone":
                    DGVPeople.DataSource = clsPeople.GetPersonByPhone(SearchKeyword);
                    break;

                case "Email":
                    DGVPeople.DataSource = clsPeople.GetPersonByEmail(SearchKeyword);
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
            if(!String.IsNullOrEmpty(tbSearchBy.Text))
            {
                SearchBySelectedFilter(tbSearchBy.Text);
            }
            else if (tbSearchBy.Visible) // if it is visible then the user has cleared the search box so we rest the view to default 
            {
                RefreshDataGridView(); // rest the dgv after clearing the search box 
            }
        }


        private void DGVPeople_SelectionChanged(object sender, EventArgs e)
        {
            if (DGVPeople.CurrentRow != null && DGVPeople.CurrentRow.Cells != null && int.TryParse(DGVPeople.CurrentRow.Cells[0]?.Value?.ToString(), out int Row) )
            {
                selectedRowIndex = Row;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // we will use another form to add or edit a person, so we will just show a message box for now
        private void Add_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frmAddEditPerson = new frmAddEditPerson(-1); // not implemented yet, but we will pass -1 to indicate that we are adding a new person
            frmAddEditPerson.ShowDialog();
            frmAddEditPerson.Dispose();
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Add")
            {

            }
            if (e.ClickedItem.Text == "Edit") // it depends on selected row index 
            {
           
            }
            if(e.ClickedItem.Text == "Show Details")
            {
                FrmShowPersonDetails personDetails = new FrmShowPersonDetails(this.selectedRowIndex);
                personDetails.ShowDialog();
                personDetails.Dispose();
            }

            if(e.ClickedItem.Text == "Delete")
            {
                // Not implemented yet.
            }
        }


    }
}
