using System;
using System.Windows.Forms;
using BussinessLogicLayer;

namespace FrontEnd
{       
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void TSMPeople_Click(object sender, EventArgs e) // mamge people 
        {
            FrmPeopleManagement frmManagePeople = new FrmPeopleManagement();
            frmManagePeople.ShowDialog();
        }

    }
}
