namespace FrontEnd
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            TSMPeople = new ToolStripMenuItem();
            soonToolStripMenuItem = new ToolStripMenuItem();
            accountSettToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            ShowCurrentUserInfo = new ToolStripMenuItem();
            changeCurrentUserPasswordToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            applicationsToolStripMenuItem = new ToolStripMenuItem();
            manageAppliToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Gainsboro;
            menuStrip1.ImageScalingSize = new Size(30, 30);
            menuStrip1.Items.AddRange(new ToolStripItem[] { TSMPeople, soonToolStripMenuItem, accountSettToolStripMenuItem, applicationsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1758, 39);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // TSMPeople
            // 
            TSMPeople.BackColor = Color.Silver;
            TSMPeople.BackgroundImageLayout = ImageLayout.Zoom;
            TSMPeople.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TSMPeople.ForeColor = Color.Black;
            TSMPeople.Image = Properties.Resources.People_64;
            TSMPeople.Name = "TSMPeople";
            TSMPeople.Size = new Size(130, 35);
            TSMPeople.Text = "People";
            TSMPeople.Click += TSMPeople_Click;
            // 
            // soonToolStripMenuItem
            // 
            soonToolStripMenuItem.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            soonToolStripMenuItem.Image = Properties.Resources.Users_2_64;
            soonToolStripMenuItem.Name = "soonToolStripMenuItem";
            soonToolStripMenuItem.Size = new Size(208, 35);
            soonToolStripMenuItem.Text = "Manage Users";
            soonToolStripMenuItem.Click += ManageUsersToolStripMenuItem_Click;
            // 
            // accountSettToolStripMenuItem
            // 
            accountSettToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, ShowCurrentUserInfo, changeCurrentUserPasswordToolStripMenuItem, logoutToolStripMenuItem });
            accountSettToolStripMenuItem.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountSettToolStripMenuItem.Image = Properties.Resources.account_settings_64;
            accountSettToolStripMenuItem.Name = "accountSettToolStripMenuItem";
            accountSettToolStripMenuItem.Size = new Size(187, 35);
            accountSettToolStripMenuItem.Text = "My Account";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(436, 6);
            // 
            // ShowCurrentUserInfo
            // 
            ShowCurrentUserInfo.Image = Properties.Resources.PersonDetails_32;
            ShowCurrentUserInfo.Name = "ShowCurrentUserInfo";
            ShowCurrentUserInfo.Size = new Size(439, 36);
            ShowCurrentUserInfo.Text = "Show Current User Info";
            ShowCurrentUserInfo.Click += showCurrentUserInfo_Click;
            // 
            // changeCurrentUserPasswordToolStripMenuItem
            // 
            changeCurrentUserPasswordToolStripMenuItem.Image = Properties.Resources.Password_32;
            changeCurrentUserPasswordToolStripMenuItem.Name = "changeCurrentUserPasswordToolStripMenuItem";
            changeCurrentUserPasswordToolStripMenuItem.Size = new Size(439, 36);
            changeCurrentUserPasswordToolStripMenuItem.Text = "Change Current User Password";
            changeCurrentUserPasswordToolStripMenuItem.Click += changeCurrentUserPasswordToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Image = Properties.Resources.sign_out_32__2;
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(439, 36);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(155, 290);
            label1.Name = "label1";
            label1.Size = new Size(1163, 145);
            label1.TabIndex = 1;
            label1.Text = "Welcome To DVLD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(204, 454);
            label2.Name = "label2";
            label2.Size = new Size(1103, 48);
            label2.TabIndex = 2;
            label2.Text = "Driving and Vehicle License Department Management";
            // 
            // applicationsToolStripMenuItem
            // 
            applicationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageAppliToolStripMenuItem });
            applicationsToolStripMenuItem.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            applicationsToolStripMenuItem.Image = Properties.Resources.Applications_64;
            applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            applicationsToolStripMenuItem.Size = new Size(193, 35);
            applicationsToolStripMenuItem.Text = "Applications";
            // 
            // manageAppliToolStripMenuItem
            // 
            manageAppliToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageAppliToolStripMenuItem.Image = Properties.Resources.Application_Types_64;
            manageAppliToolStripMenuItem.Name = "manageAppliToolStripMenuItem";
            manageAppliToolStripMenuItem.Size = new Size(349, 36);
            manageAppliToolStripMenuItem.Text = "Manage Application Types";
            manageAppliToolStripMenuItem.Click += manageAppliToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1758, 822);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "DVLD Main Form";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem TSMPeople;
        private Label label1;
        private Label label2;
        private ToolStripMenuItem soonToolStripMenuItem;
        private ToolStripMenuItem accountSettToolStripMenuItem;
        private ToolStripMenuItem ShowCurrentUserInfo;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem changeCurrentUserPasswordToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem applicationsToolStripMenuItem;
        private ToolStripMenuItem manageAppliToolStripMenuItem;
    }
}
