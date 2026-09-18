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
        enFormStatus formStatus;

        public frmAddEditUser(int UserID)
        {
            InitializeComponent();
            this.ctrlFilterFindBy2.OnPersonFound += GetPersonFoundedOrAdded;

            if (UserID == -1)
            {
                formStatus = enFormStatus.Add;
                this.ctrlFilterFindBy2.Enabled = true;
            }
            else
            {
                formStatus = enFormStatus.Edit;
                this.ctrlFilterFindBy2.Enabled = false;
            }

            btnSave.Enabled = false;
            btnNext.Enabled = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedIndex = 1;

        }

        bool IsThisPersonRegisteredAsUser(int PersonID)
        {
            return clsUsers.IsUserISAPerson(PersonID);
        }

        void GetPersonFoundedOrAdded(int PersonID) // when a person is found or added, this method will be called
        {
            if (IsThisPersonRegisteredAsUser(PersonID))
            {
                ctrlPersonInfo1.RestToDefault();
                MessageBox.Show("This person is already registered as a user in the system. You cannot add this person as a user again.", "Person Already Registered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSave.Enabled = false;
                btnNext.Enabled = false;
            }
            else
            {
                this.ctrlPersonInfo1.LoadInfoUsingPersonID(PersonID);
                btnSave.Enabled = true;
                btnNext.Enabled = true;
            }

        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e) // to prevent user from going to the next tab if the person is not selected or added
        {
            e.Cancel = !btnNext.Enabled; // if the next button is not enabled, cancel the tab change
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }



    }
}
