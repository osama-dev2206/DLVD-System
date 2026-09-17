using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class frmShowCurrentUserInfo : Form
    {
        int UserPersonID { get; set; }
        int UserID { get; set;  }
        public frmShowCurrentUserInfo(int PersonID , int UserID)
        {
            this.UserPersonID = PersonID;
            this.UserID = UserID;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
