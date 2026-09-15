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
            if (!string.IsNullOrEmpty(tbUsername.Text))
            {
                Username = tbUsername.Text;
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbPassword.Text))
            {
                Password = tbPassword.Text;
            }
        }

        private void tbUserNamePassword_Validating(object sender, CancelEventArgs e)
        {

        }


    }
}
