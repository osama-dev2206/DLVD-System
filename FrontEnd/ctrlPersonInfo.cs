using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BussinessLogicLayer;

namespace FrontEnd
{
    public partial class ctrlPersonInfo : UserControl
    {
        clsPeople? Person;
        public ctrlPersonInfo(int PersonID)
        {
            InitializeComponent();

            if(PersonID > 0 && int.TryParse(PersonID.ToString() , out _ ) )
            {
                Person= clsPeople.GetPersonObjectByPersonID( PersonID );
                UpdateUserControl();

            }

        }

        void UpdateUserControl()
        {
            if(Person is not null)
            {
                this.labPersonID.Text = Person.PersonID.ToString();
                this.labPersonName.Text = Person.FirstName+" "+Person.SecondName +" " + Person.ThirdName + " " + Person.LastName;
                this.labPersonNationalNo.Text = Person.NationalNumber.ToString();
                this.labPersonGender.Text = Person.Gender.ToString();
                this.labPersonEmail.Text = Person.Email.ToString();
                this.labPersonAddress.Text = Person.Address.ToString();
                this.labDateOfBirth.Text = Person.DateOfBirth.ToString();
                this.labPersonPhone.Text = Person.Phone.ToString();
                this.labPersonCountry.Text = Person.NationalityCountry.ToString();
                if(File.Exists(Person.ImagePath))
                 this.pbPFP.Image = Image.FromFile("@"+Person.ImagePath);
            }
        }

    }
}
