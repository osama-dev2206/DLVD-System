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

        clsUsers user;

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
            if (String.IsNullOrEmpty(tbCurrentPassword.Text) && tbCurrentPassword.Text == this.user.Password)
            {
                errorProvider1.SetError(tbCurrentPassword, "the current password is not valid !");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbCurrentPassword, string.Empty);
                e.Cancel = false;
            }
        }

        private void tbNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbCurrentPassword.Text))
            {
                errorProvider1.SetError(tbNewPassword, "the new password cann't be empty ! ");
                e.Cancel = true;
            }
            else if (tbNewPassword.Text == this.user.Password)
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

            else if (this.tbConfrimPassword.Text == this.user.Password)
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
                this.user.Password = this.NewPassword; 
                e.Cancel = false;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void frmChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        bool isValidPassword()
        {
            return !string.IsNullOrEmpty(tbCurrentPassword.Text) && !string.IsNullOrEmpty(tbNewPassword.Text) && 
                !string.IsNullOrEmpty(tbConfrimPassword.Text) && (tbNewPassword.Text == tbConfrimPassword.Text && tbCurrentPassword.Text == this.user.Password);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(isValidPassword())
            {

            }
        }
    }
}
