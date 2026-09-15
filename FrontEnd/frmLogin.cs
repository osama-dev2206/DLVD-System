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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        string Username { get; set; }
        string Password { get; set; }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbUsername.Text) )
            {
                Username = tbUsername.Text;
            }
          
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbPassword.Text) )
            {
                Password = tbPassword.Text;
                errorProvider1.SetError(tbPassword, string.Empty);
            }
         
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (!clsUsers.IsUserNameExist(Username) || String.IsNullOrEmpty(Username))
            {
                errorProvider1.SetError(tbUsername, "Username does not exist.");
         
            }
            else
            {
                errorProvider1.SetError(tbUsername, string.Empty);

            }

            if (Password == null || string.IsNullOrEmpty(Password))
            {
                errorProvider1.SetError(tbPassword, "password cannot be empty.");
     
            }
            else
            {
                errorProvider1.SetError(tbPassword, string.Empty);

            }

            }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }


        public Action<bool> OnUserLoggedSuccess;
        void RaiseOnUserLoggedSuccess(bool isLoggedIn)
        {
            OnUserLoggedSuccess?.Invoke(isLoggedIn);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(clsUsers.IsLoginValid(Username, Password))
            {
                this.DialogResult = DialogResult.OK;
                RaiseOnUserLoggedSuccess(true);
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            clsCurrentLoggedInUser.User = null;

        }




    }
}
