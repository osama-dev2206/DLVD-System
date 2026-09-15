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
        public frmShowCurrentUserInfo(int PersonID)
        {
            this.UserPersonID = PersonID;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
