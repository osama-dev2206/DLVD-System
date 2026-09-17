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
    public partial class frmAddEditUser : Form
    {
        enum enFormStatus : byte { Add = 1, Edit = 2 }

        public frmAddEditUser(int UserID)
        {
            InitializeComponent();
            this.ctrlFilterFindBy2.OnPersonFound += GetPersonFoundedOrAdded;
            btnSave.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedIndex = 1;

        }

        void IsThisPersonRegisteredAsUser(int PersonID )
        {
            if (clsUsers.IsUserISAPerson(PersonID))
            {
                MessageBox.Show("This person is already registered as a user.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        void GetPersonFoundedOrAdded(clsPeople person)
        {
            this.ctrlPersonInfo1.LoadInfoUsingPersonObject(person);
            IsThisPersonRegisteredAsUser(person.PersonID);
        }
       


    }
}
