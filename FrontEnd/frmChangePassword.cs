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
    public partial class frmChangePassword : Form
    {
        int PersonID { get; set; }
        int UserID { get; set; }

        string NewPassword { get; set; }

        clsUsers   user;

        public frmChangePassword(int PersonID, int UserID)
        {
            if (!int.TryParse(PersonID.ToString(), out _) || !int.TryParse(UserID.ToString(), out _))
            {
                return;
            }

            InitializeComponent();

            this.PersonID = PersonID;
            this.UserID = UserID;
            this.ctrlPersonInfo1.LoadInfoUsingPersonID(PersonID);
            this.ctrlShowUserInfo1.CtrlShowUserInfo_Load(UserID);
            user = clsUsers.FindUserByUserIDAsObj(UserID);
           
        }


        private void tbCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbCurrentPassword.Text))
            {
                errorProvider1.SetError(tbCurrentPassword, "the current password is not valid !");
                e.Cancel = true;
            }
            else if(this.user.CheckIfNewPasswordMatchesTheOld(tbCurrentPassword.Text) )
            {
                errorProvider1.SetError(tbCurrentPassword, "");
                e.Cancel = false;
            }
            else
            {
                errorProvider1.SetError(tbCurrentPassword, string.Empty);
                e.Cancel = false;
            }
        }

        private void tbNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbNewPassword.Text))
            {
                errorProvider1.SetError(tbNewPassword, "the new password cann't be empty ! ");
                e.Cancel = true;
            }
            else if (this.user.CheckIfNewPasswordMatchesTheOld(tbNewPassword.Text)  )
            {
                errorProvider1.SetError(tbNewPassword, "the new password cannot be the same as old password ! ");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbNewPassword, string.Empty);
                this.NewPassword = tbNewPassword.Text; // to check if the new password is the same as the confirmation password
       
                e.Cancel = false;
            }
        }


        private void tbConfrimPassword_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbConfrimPassword.Text))
            {
                errorProvider1.SetError(tbConfrimPassword, "the confrimation password cann't be empty ! ");
                e.Cancel = true;
            }

            else if ( this.user.CheckIfNewPasswordMatchesTheOld(this.tbConfrimPassword.Text) ) 
            {
                errorProvider1.SetError(tbConfrimPassword, "the confrimation password cannot be the same as old password ! ");
                e.Cancel = true;
            }
            else if (this.tbConfrimPassword.Text != this.tbNewPassword.Text)
            {
                errorProvider1.SetError(tbConfrimPassword, "the confrimation password must be the same as new password ! ");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbConfrimPassword, string.Empty);
             
                e.Cancel = false;
            }

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        bool isValidPassword()
        {
            return !string.IsNullOrEmpty(tbCurrentPassword.Text) && !string.IsNullOrEmpty(tbNewPassword.Text) && 
                !string.IsNullOrEmpty(tbConfrimPassword.Text) && (tbNewPassword.Text == tbConfrimPassword.Text );
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(isValidPassword() )
            {
                this.user.Password = this.NewPassword.Trim(); // update the password in the user object

                if ( !String.IsNullOrEmpty(NewPassword) && this.user.Save())
                {
                    clsUsers.DeleteSavedLoginInfo(); // delete the saved login info (as the user password Has changed) to force the user to login again with the new password
                    MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Failed to change password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Please ensure all password fields are filled correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


    }
}
