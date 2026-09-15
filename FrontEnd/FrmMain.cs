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

        private void TSMPeople_Click(object sender, EventArgs e) // manage people 
        {
            FrmPeopleManagement frmManagePeople = new FrmPeopleManagement();
            frmManagePeople.ShowDialog();
        }

        private void showCurrentUserInfo_Click(object sender, EventArgs e)
        {
            frmShowCurrentUserInfo frmShowCurrentUserInfo = new frmShowCurrentUserInfo(clsCurrentLoggedInUser.User.PersonID);
            frmShowCurrentUserInfo.ShowDialog();
        }

        internal Action<bool> OnUserLogOut;

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnUserLogOut?.Invoke(true);
            this.Close();
        }



    }
}
