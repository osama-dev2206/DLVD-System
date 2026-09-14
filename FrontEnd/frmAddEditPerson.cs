using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class frmAddEditPerson : Form
    {
        int PersonID{get; set;}
        public frmAddEditPerson(int ID)
        {
            PersonID = ID;
            InitializeComponent();
            this.label1.Text = (PersonID ==-1) ? "Add New Person" : "Edit Person";

        }

        // Event
        void UpdatePersonIDAfterSaving(int PersonID)
        {
            this.lblPersonID.Text = PersonID.ToString();
        }



    }
}
