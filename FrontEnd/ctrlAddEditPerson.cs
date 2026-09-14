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
    public partial class ctrlAddEditPerson : UserControl
    {
        clsPeople? person;
        enum enMode { Add, Edit }
        enMode FormMode;

        public ctrlAddEditPerson()
        {
            InitializeComponent();
        }

        public ctrlAddEditPerson(int PersonID)
        {
            InitializeComponent();

            if (PersonID == -1) // Add New Person
            {
                pbIndicator.Visible = true;
                person = new clsPeople(); // create a new instance of clsPeople for adding a new person
                FormMode = enMode.Add;
            }
            // Edit 
        }

        private void ctrlAddEditPerson_Load(object sender, EventArgs e)
        {
            FillCountriesInComboBox(); // fill the combobox with countries from the database
            cbCountry.Text = "Egypt"; // set the default country to Egypt
            this.rbMale.Checked = true; // set the default gender to Male
            this.dtDateOfBirth.MaxDate = DateTime.Now.AddYears(-18); // set the default date of birth to 18 years ago
        }

        void FillCountriesInComboBox()
        {
            foreach (DataRow R in clsPeople.GetAllCountries().Rows)
            {
                this.cbCountry.Items.Add(R["CountryName"].ToString());
            }
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbFirstName.Text))
            {
                person?.FirstName = tbFirstName.Text;
            }
            else
                errorProvider1.SetError(tbFirstName, "The first name field must be filled");
        }

        private void tbSecondName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbSecondName.Text))
            {
                person?.SecondName = tbSecondName.Text;
            }
            else
                errorProvider1.SetError(tbSecondName, "The second name field must be filled");
        }

        private void tbThirdName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbThirdName.Text))
            {
                person?.ThirdName = tbThirdName.Text;
            }
            else            
                errorProvider1.SetError(tbThirdName, "The Third name field must be filled");
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbLastName.Text))
            {
                person?.LastName = tbLastName.Text;
            }
            else
                errorProvider1.SetError(tbLastName, "The last name field must be filled");
        }

        private void tbNationalNum_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbNationalNum.Text))
            {
                person?.NationalNumber = tbNationalNum.Text;
            }
            else
                errorProvider1.SetError(tbNationalNum, "The national no field must be filled");
        }

        private void rbGender_Click(object sender, EventArgs e)
        {
            // 1 : male , 2 : female
            if (rbMale.Checked)
            {
                if (String.IsNullOrEmpty(this?.person?.ImagePath)) this.pbPFP.Image = Properties.Resources.Male_512;
                this?.person?.Gender = 1;
            }
            else if (rbFemale.Checked)
            {
                if (String.IsNullOrEmpty(this?.person?.ImagePath)) this.pbPFP.Image = Properties.Resources.Female_512;
                this?.person?.Gender = 2;
            }

        }

        private void mtbEmail_TextChanged(object sender, EventArgs e)
        {
            if (mtbEmail.MaskCompleted && !string.IsNullOrEmpty(mtbEmail.Text))
            {
                this.person?.Email = mtbEmail.Text;
            }

        }

        private void dtDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            if (dtDateOfBirth.Value != null)
            {
                this.person?.DateOfBirth = DateOnly.FromDateTime(dtDateOfBirth.Value);
            }
            else
                errorProvider1.SetError(dtDateOfBirth, "The date of birth field must be filled");
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbPhone.Text))
            {
                this.person?.Phone = tbPhone.Text;
            }
            else
                errorProvider1.SetError(tbPhone, "The phone field must be filled");
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            if ((tbAddress.Text != null) && (tbAddress.Text.Length > 0))
            {
                this.person?.Address = tbAddress.Text;
            }
            else
                errorProvider1.SetError(tbAddress, "The address field must be filled");
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCountry.SelectedIndex != -1 && !string.IsNullOrEmpty(cbCountry?.SelectedItem?.ToString()))
            {
                person?.NationalityCountry = cbCountry?.SelectedItem?.ToString(); // when you add the bussiness logic layer you will need to get the country id from the database and set it to the person object
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (person.Save())
            {
                MessageBox.Show("Person saved successfully.");
                pbIndicator.Visible = false;
                OnPersonSaving(); // raise the event to notify that the person has been saved and pass the person ID to the parent form
            }
            else
            {
                MessageBox.Show("Failed to save person.");
            }

        }

       

        // Event Handler To Update The person ID in another form 

       public  Action<int>? OnPersonSaved;
        private void OnPersonSaving()
        {
            OnPersonSaved?.Invoke(this.person.PersonID);
        }


    }
}
