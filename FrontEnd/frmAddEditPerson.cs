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
        public frmAddEditPerson(int ID)
        {
            InitializeComponent();
            this.ctrlAddEditPerson1.OnPersonSaved += UpdatePersonIDAfterSaving; // subscribe to the OnPersonSaved event of the user control


        }

        // Event
        void UpdatePersonIDAfterSaving(int PersonID)
        {
            this.lblPersonID.Text = PersonID.ToString();
        }



    }
}
