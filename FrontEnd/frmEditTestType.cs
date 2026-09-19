using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class frmEditTestType : Form
    {
        public frmEditTestType(int TestTypeID)
        {
            InitializeComponent();

            if(!int.TryParse(TestTypeID.ToString(),out _))
            {
                MessageBox.Show("Invalid Test Type ID provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



        }


    }
}
