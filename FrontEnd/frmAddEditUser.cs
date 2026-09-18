using BussinessLogicLayer;
using Microsoft.VisualBasic.ApplicationServices;
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

        clsUsers ? user;

        public frmAddEditUser(int UserID)
        {

            if(!int.TryParse(UserID.ToString(), out _))
            {
                MessageBox.Show("Invalid User ID. Please provide a valid User ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            InitializeComponent();
            this.ctrlFilterFindBy2.OnPersonFound += GetPersonFoundedOrAdded; // subscribe to the event when a person is found or added in the ctrlFilterFindBy2 control

            if (UserID == -1)
            {
                formStatus = enFormStatus.Add;
                user = new clsUsers();
                this.ctrlFilterFindBy2.Enabled = true;
                this.labFormMode.Text = "Add New User";

                // Default 
                btnSave.Enabled = false;
                btnNext.Enabled = false;
            }
            else
            {
                formStatus = enFormStatus.Edit;
                user = clsUsers.FindUserByUserIDAsObj(UserID);
                FillForm();
                this.ctrlFilterFindBy2.Enabled = false;
                this.labFormMode.Text = "Edit User";
            }


        }


        void FillForm()
        {
            if (user is not null)
            {
                this.ctrlPersonInfo1.LoadInfoUsingPersonID(user.PersonID);
               btnNext.Enabled = true;
                btnSave.Enabled = true;
                this.tbUserName.Text = user.Username;
                this.cbIsActive.Checked = this.user.IsActive;
            }
            else
            {
                MessageBox.Show("User not found. Please provide a valid User ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

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
                user.PersonID = PersonID; // set User person ID
                btnSave.Enabled = true;
                btnNext.Enabled = true;
            }

        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e) // to prevent user from going to the next tab if the person is not selected or added
        {
            e.Cancel = !btnNext.Enabled; // if the next button is not enabled, cancel the tab change
        }

        private void cbIsActive_CheckedChanged(object sender, EventArgs e)
        {
            this.user.IsActive = cbIsActive.Checked;
        }

        private void tbUserName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbUserName.Text.Trim()))
            {
                errorProvider1.SetError(tbUserName, "username cannot be empty !");
                e.Cancel = true;
            }
            else if ( this.formStatus==enFormStatus.Add && clsUsers.IsUserNameExist(tbUserName.Text.Trim()))
            {
                errorProvider1.SetError(tbUserName, "this username already exists ! ");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbUserName, String.Empty);
                e.Cancel = false;
                user.Username = tbUserName.Text.Trim();
            }


        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbPassword.Text.Trim()))
            {
                errorProvider1.SetError(tbPassword, "password cannot be empty !");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbPassword, String.Empty);
                e.Cancel = false;
            }
        }

        private void tbPasswordConfrimation_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbPasswordConfrimation.Text.Trim()))
            {
                errorProvider1.SetError(tbPasswordConfrimation, "password cannot be empty !");
                e.Cancel = true;
            }
            else if(tbPasswordConfrimation.Text.Trim() != tbPassword.Text.Trim())
            {
                errorProvider1.SetError(tbPasswordConfrimation, "password confirmation does not match the password !");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbPasswordConfrimation, String.Empty);
                e.Cancel = false;
                this.user.Password =  tbPasswordConfrimation.Text.Trim(); // set the password only if the confirmation matches
            }

        }

        bool CheckBeforeSave()
        {
            return !String.IsNullOrEmpty(user.Username) && !String.IsNullOrEmpty(user.Password) && !String.IsNullOrEmpty(tbPassword.Text)
                && !String.IsNullOrEmpty(tbPasswordConfrimation.Text)
                && ( user.PersonID != -1 || user.PersonID != null );
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckBeforeSave())
            {
                if (this.formStatus == enFormStatus.Add && user.Save())
                {
                    MessageBox.Show("User saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.formStatus = enFormStatus.Edit;

                }
                else if (this.formStatus == enFormStatus.Edit && user.Save())
                {
                    MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"User Failed to {this.formStatus.ToString()} Please check the information and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
