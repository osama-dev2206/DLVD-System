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


        /*

Phone
Email
         */
        void SearchBySelectedFilter(string SearchKeyword) // this method will handle the search by selected filter
        {

            if (cbFilter.SelectedItem == "PersonID" && int.TryParse(SearchKeyword, out int id))
            {
                DGVPeople.DataSource = clsPeople.GetPersonByPersonID(id);
            }

            if (cbFilter.SelectedItem == "NationalNo")
            {
                DGVPeople.DataSource = clsPeople.GetPersonByNationalNo(SearchKeyword);
            }

            if (cbFilter.SelectedItem == "FirstName")
            {
                DGVPeople.DataSource = clsPeople.GetPersonByFirstName(SearchKeyword);
            }

            if (cbFilter.SelectedItem == "SecondName")
            {
                DGVPeople.DataSource = clsPeople.GetPersonBySecondName(SearchKeyword);
            }

            if (cbFilter.SelectedItem == "ThirdName")
            {
                DGVPeople.DataSource = clsPeople.GetPersonByThirdName(SearchKeyword);
            }

            if (cbFilter.SelectedItem == "LastName")
            {
                DGVPeople.DataSource = clsPeople.GetPersonByLastName(SearchKeyword);
            }

            if(cbFilter.SelectedItem == "Nationality")
            {
                DGVPeople.DataSource = clsPeople.GetPersonByNationality(SearchKeyword);
            }

           if (cbFilter.SelectedItem == "Gender")
            {
                DGVPeople.DataSource = clsPeople.GetPersonByGender(SearchKeyword);
            }


            }

             // changing the filter handling only
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex != -1 && cbFilter.SelectedItem != null && cbFilter.SelectedIndex != 0)
            {
                tbSearchBy.Visible = true;
               
            }
            else if (cbFilter.SelectedIndex == 0)
            {
                tbSearchBy.Visible = false;
                RefreshDataGridView();
                this.tbSearchBy.Text = string.Empty;
            }



        }

        private void tbSearchBy_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(tbSearchBy.Text))
            {
                SearchBySelectedFilter(tbSearchBy.Text);
            }
            else
            {
                RefreshDataGridView(); // rest the dgv after clearing the search box 
            }
        }


        private void DGVPeople_SelectionChanged(object sender, EventArgs e)
        {
            if (DGVPeople.CurrentRow != null && DGVPeople.CurrentRow.Cells != null && DGVPeople.CurrentRow.Cells[0] != null && int.TryParse(DGVPeople.CurrentRow.Cells[0].ToString(), out int Row))
            {
                selectedRowIndex = Row;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // we will use another form to add or edit a person, so we will just show a message box for now
        private void AddEdit_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frmAddEditPerson = new frmAddEditPerson(selectedRowIndex);
            frmAddEditPerson.ShowDialog();
            frmAddEditPerson.Dispose();
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == null || selectedRowIndex == -1) return;

            if (e.ClickedItem.Text == "Add" || e.ClickedItem.Text == "Edit") // it depends on selected row index 
            {
                AddEdit_Click(sender, e); //ADD 
                RefreshDataGridView();
            }

        }


    }
}
