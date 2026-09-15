using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class FrmShowPersonDetails : Form
    {
        int SelectedPersonID;
        public FrmShowPersonDetails(int PersonID)
        {
            if (int.TryParse(PersonID.ToString(), out int ID)) // please note that the user conmtrol is  handled in the runtime and the ID is passed to the form in designer file 
                this.SelectedPersonID = ID;
            InitializeComponent();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
