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
            ShowCurrentUserInfo = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            changeCurrentUserPasswordToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Gainsboro;
            menuStrip1.ImageScalingSize = new Size(30, 30);
            menuStrip1.Items.AddRange(new ToolStripItem[] { TSMPeople, soonToolStripMenuItem, accountSettToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1852, 39);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // TSMPeople
            // 
            TSMPeople.BackColor = Color.Silver;
            TSMPeople.BackgroundImageLayout = ImageLayout.Zoom;
            TSMPeople.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TSMPeople.ForeColor = Color.Black;
            TSMPeople.Image = Properties.Resources.People_64;
            TSMPeople.Name = "TSMPeople";
            TSMPeople.Size = new Size(128, 35);
            TSMPeople.Text = "People";
            TSMPeople.Click += TSMPeople_Click;
            // 
            // soonToolStripMenuItem
            // 
            soonToolStripMenuItem.Name = "soonToolStripMenuItem";
            soonToolStripMenuItem.Size = new Size(65, 35);
            soonToolStripMenuItem.Text = "Soon !";
            // 
            // accountSettToolStripMenuItem
            // 
            accountSettToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ShowCurrentUserInfo, toolStripMenuItem1, changeCurrentUserPasswordToolStripMenuItem, logoutToolStripMenuItem });
            accountSettToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountSettToolStripMenuItem.Image = Properties.Resources.account_settings_64;
            accountSettToolStripMenuItem.Name = "accountSettToolStripMenuItem";
            accountSettToolStripMenuItem.Size = new Size(164, 35);
            accountSettToolStripMenuItem.Text = "My Account";
            // 
            // ShowCurrentUserInfo
            // 
            ShowCurrentUserInfo.Image = Properties.Resources.PersonDetails_32;
            ShowCurrentUserInfo.Name = "ShowCurrentUserInfo";
            ShowCurrentUserInfo.Size = new Size(389, 36);
            ShowCurrentUserInfo.Text = "Show Current User Info";
            ShowCurrentUserInfo.Click += showCurrentUserInfo_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(386, 6);
            // 
            // changeCurrentUserPasswordToolStripMenuItem
            // 
            changeCurrentUserPasswordToolStripMenuItem.Image = Properties.Resources.Password_32;
            changeCurrentUserPasswordToolStripMenuItem.Name = "changeCurrentUserPasswordToolStripMenuItem";
            changeCurrentUserPasswordToolStripMenuItem.Size = new Size(389, 36);
            changeCurrentUserPasswordToolStripMenuItem.Text = "Change Current User Password";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Image = Properties.Resources.sign_out_32__2;
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(389, 36);
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
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.beautiful_shot_bridge_reflective_lake_sunset;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1852, 822);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
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
    }
}
