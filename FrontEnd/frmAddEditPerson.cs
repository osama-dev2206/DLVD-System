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
        int PersonID { get; set; }
        public frmAddEditPerson(int ID)
        {
     
            PersonID = ID;
            InitializeComponent(); // the id will be passed to the user control to determine if we are adding a new person or editing an existing one
            ctrlAddEditPerson1.OnPersonSaved += UpdatePersonIDAfterSaving;
            this.labFormState.Text = (PersonID == -1) ? "Add New Person" : "Edit Person";

        }

        // Event
        void UpdatePersonIDAfterSaving(int PersonID)
        {
            this.lblPersonID.Text = PersonID.ToString();
            this.labFormState.Text = "Edit Person";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
