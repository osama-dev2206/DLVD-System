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
            frmShowCurrentUserInfo frmShowCurrentUserInfo = new frmShowCurrentUserInfo(clsCurrentLoggedInUser.User.PersonID, clsCurrentLoggedInUser.User.UserID);
            frmShowCurrentUserInfo.ShowDialog();
        }

        internal Action<bool> OnUserLogOut;

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnUserLogOut?.Invoke(true);
            this.Close();
        }

        private void changeCurrentUserPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword(clsCurrentLoggedInUser.User.PersonID, clsCurrentLoggedInUser.User.UserID);
            frmChangePassword.ShowDialog();
            frmChangePassword.Dispose();
        }

        private void ManageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageUsers frmManageUsers = new frmManageUsers();
            frmManageUsers.ShowDialog();
            frmManageUsers.Dispose();
        }

        private void manageAppliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApplicationTypes frmApplicationTypes = new frmApplicationTypes();
            frmApplicationTypes.ShowDialog();
            frmApplicationTypes.Dispose();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestTypes frmManageTestTypes = new frmManageTestTypes();
            frmManageTestTypes.ShowDialog();
            frmManageTestTypes.Dispose();
        }


    }
}
