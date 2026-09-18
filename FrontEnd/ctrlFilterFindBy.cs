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
    public partial class ctrlFilterFindBy : UserControl
    {
        int PersonID { get; set; }
        string NationalNo { get; set; }
        clsPeople person;

        public ctrlFilterFindBy()
        {
            InitializeComponent();
            PersonID = -1; // initialize PersonID to an invalid value
            tbSeach.Enabled = false;
        }


        private void tbSeach_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbSeach.Text))
            {
                if (cbFilter.SelectedItem == "PersonID" && int.TryParse(tbSeach.Text.Trim(), out int ID))
                {
                    this.PersonID = ID;
                }

                else if (cbFilter.SelectedItem == "NationalNO")
                {
                    this.NationalNo = tbSeach.Text.Trim();
                }
            }

            else
            {
                MessageBox.Show("Please enter a value to search.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ctrlFilterFindBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedItem == "PersonID")
            {
                // Allow only digits and control characters (like backspace)
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Ignore the input
                }
            }
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if (cbFilter.SelectedItem == "NationalNO" && !String.IsNullOrEmpty(this.NationalNo))
            {
                person = clsPeople.GetPersonObjectByNationalNo(NationalNo);

                if (person == null)
                {
                    MessageBox.Show("No person found with the given National No.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else 
                OnPersonFound?.Invoke(this.person.PersonID); // invoke the event to notify that a person has been found
            }

            else if (cbFilter.SelectedItem == "PersonID" && PersonID != -1)
            {
                person = clsPeople.GetPersonObjectByPersonID(this.PersonID);
                if (person == null)
                {
                    MessageBox.Show("No person found with the given PersonID.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return; // Exit the method if no person is found
                }
                else 
                OnPersonFound?.Invoke(this.person.PersonID); // invoke the event to notify that a person has been found 
            }

        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frmAddEditPerson = new frmAddEditPerson(-1); // add new person (if it is not existing person, we will pass -1 to the form to indicate that we are adding a new person)
            frmAddEditPerson.ShowDialog();

                this.PersonID = frmAddEditPerson.PersonID; // update the PersonID after adding a new person( the person id will  be returned from event)

            OnPersonFound?.Invoke(this.PersonID); // invoke the event to notify that a person has been found or added)

            frmAddEditPerson.Dispose();
        }


        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSeach.Enabled = true;
        }


        internal Action<int> OnPersonFound; // on person found or added event to notify the parent form that a person has been found or added




    }
}
