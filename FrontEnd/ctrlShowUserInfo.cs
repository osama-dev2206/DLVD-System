using BussinessLogicLayer;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class ctrlShowUserInfo : UserControl
    {
        public ctrlShowUserInfo()
        {
            InitializeComponent();
        }

        clsUsers ? User;
        int UserID { get; set; }
        public ctrlShowUserInfo(int UserId)
        {
            InitializeComponent();
            this.UserID = UserId;
            if (!int.TryParse(UserId.ToString(), out _)) return;
            User = clsUsers.FindUserByUserIDAsObj(UserId);
            UpdateFormInfo();
        }

        void UpdateFormInfo()
        {
            if (User is null) return; 
            this.labUserID.Text = User.UserID.ToString();
            this.labUsername.Text = User.Username;
            this.labIsActive.Text = (User.IsActive) ? "Yes" : "No";
        }

        // using the same control without passing the user id will not show any information
        public void CtrlShowUserInfo_Load(int UserID)
        {
                User = clsUsers.FindUserByUserIDAsObj(UserID);
                UpdateFormInfo();
        }

        public void RefreshUserInfo()
        {
            User = clsUsers.FindUserByUserIDAsObj(this.UserID);
            UpdateFormInfo();
        }


        }
}
