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
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]

        public int SentPersonID { private get; set; }
        public ctrlPersonInfo() { InitializeComponent(); } // تسليكي كدا هنعدل بعدين في ديزاينر بتاع فورم الي هيستعمل كنترول دا 

        public ctrlPersonInfo(int SentPersonID)
        {
            InitializeComponent();
            this.SentPersonID = SentPersonID;
            if (SentPersonID > 0 && int.TryParse(SentPersonID.ToString(), out _))
            {
                Person = clsPeople.GetPersonObjectByPersonID(SentPersonID);
                UpdateUserControl();

            }
        }


        void UpdateUserControl()
        {
            if (Person is not null)
            {
                this.labPersonID.Text = Person.PersonID.ToString();
                this.labPersonName.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName.Trim() + " " + Person.LastName;
                this.labPersonNationalNo.Text = Person.NationalNumber.ToString();
                this.labPersonGender.Text = (Person.Gender ==1  )? "M" : "F" ;
                this.labPersonEmail.Text = Person.Email.ToString();
                this.labPersonAddress.Text = Person.Address.ToString();
                this.labDateOfBirth.Text = Person.DateOfBirth.ToString();
                this.labPersonPhone.Text = Person.Phone.ToString();
                this.labPersonCountry.Text = Person.NationalityCountry.ToString();
                if (File.Exists(Person.ImagePath))
                    this.pbPFP.Image = Image.FromFile(Person.ImagePath);
            }
        }

 
    }
}
