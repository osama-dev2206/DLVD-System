using BussinessLogicLayer;
using FrontEnd.Properties;
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

        public ctrlAddEditPerson() // Temp For Intilization ONLY NOR REAL USE
        {
            InitializeComponent();
            person = new clsPeople(); // create a new instance of clsPeople for adding a new person
        }

        public ctrlAddEditPerson(int PersonID)
        {
            InitializeComponent();

            FillCountriesInComboBox(); // fill the combobox with countries from the database

            if (PersonID == -1) // Add New Person
            {
                pbIndicator.Visible = true;
                person = new clsPeople(); // create a new instance of clsPeople for adding a new person
                FormMode = enMode.Add;
            }
            else // Edit
            {
                FormMode = enMode.Edit;
                this.person = clsPeople.GetPersonObjectByPersonID(PersonID); // get the person from the database by ID)
                FillForm();
            
            }

        }

        private void ctrlAddEditPerson_Load(object sender, EventArgs e)
        {
     
            this.dtDateOfBirth.MaxDate = DateTime.Now.AddYears(-18); // set the default date of birth to 18 years ago

            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads"; ;
            openFileDialog1.DefaultExt = ".jpg";
            openFileDialog1.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
            openFileDialog1.FileName = "Photo.jpg";//to set the default opening file 

            if (FormMode == enMode.Add)
            {
                cbCountry.Text = "Egypt"; // set the default country to Egypt
                this.rbMale.Checked = true; // set the default gender to Male
                this.person.Gender = 1; // default gender to Male
                if (String.IsNullOrEmpty(this?.person?.ImagePath)) this.pbPFP.Image = Properties.Resources.Male_512;

            }


            if (person.ImagePath is null || person.ImagePath == "" || !File.Exists(person.ImagePath)) // set the default image if the person has no image or the image path is invalid
            {
                SetDefaultPFP();
                lblSetImage.Visible = true;
                labRemoveImage.Visible = false;
            }
            else // set the image from the person's image path if it exists
            {
                //this.pbPFP.Image = Image.FromFile(this.person.ImagePath);

                using (var stream = new FileStream(
             person.ImagePath,
             FileMode.Open,
             FileAccess.Read,
             FileShare.Read))
                {
                    using (var temp = Image.FromStream(stream))
                    {
                        pbPFP.Image = new Bitmap(temp);
                    }
                }

                lblSetImage.Visible = false;
                labRemoveImage.Visible = true;
            }


        }

        void FillForm()
        {
            if (person != null)
            {

                this.tbFirstName.Text = person.FirstName;
                this.tbSecondName.Text = person.SecondName;
                this.tbThirdName.Text = person.ThirdName;
                this.tbLastName.Text = person.LastName;

                this.tbNationalNum.Text = person.NationalNumber;
                _ = (person.Gender == 1) ? this.rbMale.Checked = true : this.rbFemale.Checked = true;

                if (!string.IsNullOrEmpty(person.Email)) this.mtbEmail.Text = person.Email;

                this.dtDateOfBirth.Value = person.DateOfBirth.ToDateTime(TimeOnly.MinValue);

                this.tbPhone.Text = person.Phone;

                this.tbAddress.Text = person.Address;

                this.cbCountry.Text = ( person.NationalityCountry.Trim());



            }
        }

        void SetDefaultPFP()
        {
            if (person?.Gender == 1) this.pbPFP.Image = Properties.Resources.Male_512;
            else if (person?.Gender == 2) this.pbPFP.Image = Properties.Resources.Female_512;
        }

        void FillCountriesInComboBox()
        {
            foreach (DataRow R in clsPeople.GetAllCountries().Rows)
            {
                this.cbCountry.Items.Add(R["CountryName"].ToString());
            }
        }


        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void tbAddresstbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( !char.IsDigit(e.KeyChar) && e.KeyChar != '+' && e.KeyChar != ' ' && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbFirstName.Text))
            {
                person?.FirstName = tbFirstName.Text;
                errorProvider1.SetError(tbFirstName, "");
            }
            else
                errorProvider1.SetError(tbFirstName, "The first name field must be filled");
        }

        private void tbSecondName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbSecondName.Text))
            {
                person?.SecondName = tbSecondName.Text;
                errorProvider1.SetError(tbSecondName, "");
            }
            else
                errorProvider1.SetError(tbSecondName, "The second name field must be filled");
        }

        private void tbThirdName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbThirdName.Text))
            {
                person?.ThirdName = tbThirdName.Text;
                errorProvider1.SetError(tbThirdName, "");
            }
            else
                errorProvider1.SetError(tbThirdName, "The Third name field must be filled");
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbLastName.Text))
            {
                person?.LastName = tbLastName.Text;
                errorProvider1.SetError(tbLastName, "");
            }
            else
                errorProvider1.SetError(tbLastName, "The last name field must be filled");
        }

        private void tbNationalNum_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbNationalNum.Text))
            {
                if (this.FormMode == enMode.Add && clsPeople.IsNationalNumberExists(tbNationalNum.Text))
                {
                    errorProvider1.SetError(tbNationalNum, "you have entered existed national num ");
                    return;
                }

                person?.NationalNumber = tbNationalNum.Text;
                errorProvider1.SetError(tbNationalNum, "");
            }
            else if(String.IsNullOrEmpty(tbNationalNum.Text) && this.FormMode == enMode.Add)
                errorProvider1.SetError(tbNationalNum, "The national num field must be filled");
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
                errorProvider1.SetError(dtDateOfBirth, "");
            }
            else
                errorProvider1.SetError(dtDateOfBirth, "The date of birth field must be filled");
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbPhone.Text))
            {
                this.person?.Phone = tbPhone.Text;
                errorProvider1.SetError(tbPhone, "");
            }
            else
                errorProvider1.SetError(tbPhone, "The phone field must be filled");
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            if ((tbAddress.Text != null) && (tbAddress.Text.Length > 0))
            {
                this.person?.Address = tbAddress.Text;
                errorProvider1.SetError(tbAddress, "");
            }
            else
                errorProvider1.SetError(tbAddress, "The address field must be filled");
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCountry.SelectedIndex != -1 && !string.IsNullOrEmpty(cbCountry?.SelectedItem?.ToString()))
            {
                person?.NationalityCountry = cbCountry?.SelectedItem?.ToString(); // when you add the bussiness logic layer you will need to get the country id from the database and set it to the person object
                person?.NationalityCountryID = clsPeople.GetCountryIDByItsName(cbCountry?.SelectedItem?.ToString());
            }
        }

        bool CheckBeforeSave()
        {
            return
                !(
                string.IsNullOrEmpty(tbFirstName.Text) || string.IsNullOrEmpty(tbSecondName.Text) || string.IsNullOrEmpty(tbThirdName.Text)
                || string.IsNullOrEmpty(tbLastName.Text) || string.IsNullOrEmpty(tbNationalNum.Text) ||
                string.IsNullOrEmpty(tbPhone.Text) || string.IsNullOrEmpty(tbAddress.Text) || string.IsNullOrEmpty(cbCountry?.SelectedItem?.ToString())
                || dtDateOfBirth?.Value == null || person?.ImagePath == null
                );
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.FormMode == enMode.Add)
            {
                if (CheckBeforeSave() && person.Save())
                {
                    MessageBox.Show("Person saved successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pbIndicator.Visible = false;
                    OnPersonSaving(); // raise the event to notify that the person has been saved and pass the person ID to the parent form
                    FormMode = enMode.Edit; // change the form mode to edit after saving
                    return; // exit the method to prevent updating the person again in the edit mode
                }
                else
                {
                    MessageBox.Show("Failed to save person.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if(this.FormMode == enMode.Edit)
            {
        
                if (this.CheckBeforeSave() && person.Save())
                { 
                        MessageBox.Show("Person updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update person.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }



        // Event Handler To Update The person ID in another form 
        public Action<int>? OnPersonSaved;
        private void OnPersonSaving()
        {
            OnPersonSaved?.Invoke(this.person.PersonID);
        }

        private void lblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
  
                this?.person?.ImagePath = openFileDialog1.FileName; // set the image path to the person object

                using (var stream = new FileStream(
             person.ImagePath,
             FileMode.Open,
             FileAccess.Read,
             FileShare.Read))
                {
                    using (var temp = Image.FromStream(stream))
                    {
                        pbPFP.Image = new Bitmap(temp);
                    }
                }

                lblSetImage.Visible = false;
                labRemoveImage.Visible = true;
            }
        }

        private void labRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetDefaultPFP();
            person?.ImagePath = null; // remove the image path from the person object (won't be saved to the database)
            lblSetImage.Visible = true;
            labRemoveImage?.Visible = false;
        }




    }
}
