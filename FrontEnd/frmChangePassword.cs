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

        public frmChangePassword(int PersonID , int UserID)
        {
            if(!int.TryParse(PersonID.ToString(), out _) || ! int.TryParse(UserID.ToString(), out _))
            {
                return;
            }

            InitializeComponent();



        }
    }
}
