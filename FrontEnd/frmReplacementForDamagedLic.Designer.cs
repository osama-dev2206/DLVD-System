namespace FrontEnd
{
    partial class frmReplacementForDamagedLic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReplacementForDamagedLic));
            grbReplacementFor = new GroupBox();
            rbLostLic = new RadioButton();
            rbDamagedLic = new RadioButton();
            ctrlDriverLicenseInfo1 = new ctrlDriverLicenseInfo();
            btnIssue = new Button();
            btnClose = new Button();
            labLicHistory = new LinkLabel();
            labNewLicenseInfo = new LinkLabel();
            ctrlFilterFindLicenseByLicid1 = new ctrlFilterFindLicenseByLicID();
            grbReplacementFor.SuspendLayout();
            SuspendLayout();
            // 
            // grbReplacementFor
            // 
            grbReplacementFor.Controls.Add(rbLostLic);
            grbReplacementFor.Controls.Add(rbDamagedLic);
            grbReplacementFor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbReplacementFor.Location = new Point(868, 30);
            grbReplacementFor.Name = "grbReplacementFor";
            grbReplacementFor.Size = new Size(284, 105);
            grbReplacementFor.TabIndex = 1;
            grbReplacementFor.TabStop = false;
            grbReplacementFor.Text = "Replacement For";
            // 
            // rbLostLic
            // 
            rbLostLic.AutoSize = true;
            rbLostLic.Location = new Point(23, 66);
            rbLostLic.Name = "rbLostLic";
            rbLostLic.Size = new Size(110, 24);
            rbLostLic.TabIndex = 1;
            rbLostLic.TabStop = true;
            rbLostLic.Text = "Lost License";
            rbLostLic.UseVisualStyleBackColor = true;
            rbLostLic.CheckedChanged += rbDamagedOrLostLic_CheckedChanged;
            // 
            // rbDamagedLic
            // 
            rbDamagedLic.AutoSize = true;
            rbDamagedLic.Location = new Point(24, 36);
            rbDamagedLic.Name = "rbDamagedLic";
            rbDamagedLic.Size = new Size(149, 24);
            rbDamagedLic.TabIndex = 0;
            rbDamagedLic.TabStop = true;
            rbDamagedLic.Text = "Damaged License";
            rbDamagedLic.UseVisualStyleBackColor = true;
            rbDamagedLic.CheckedChanged += rbDamagedOrLostLic_CheckedChanged;
            // 
            // ctrlDriverLicenseInfo1
            // 
            ctrlDriverLicenseInfo1.Location = new Point(16, 141);
            ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            ctrlDriverLicenseInfo1.Size = new Size(1136, 401);
            ctrlDriverLicenseInfo1.TabIndex = 2;
            // 
            // btnIssue
            // 
            btnIssue.FlatAppearance.BorderSize = 2;
            btnIssue.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            btnIssue.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnIssue.FlatStyle = FlatStyle.Flat;
            btnIssue.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIssue.Image = Properties.Resources.Renew_Driving_License_323;
            btnIssue.ImageAlign = ContentAlignment.BottomLeft;
            btnIssue.Location = new Point(908, 832);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(250, 50);
            btnIssue.TabIndex = 3;
            btnIssue.Text = "Issue Replacement";
            btnIssue.UseVisualStyleBackColor = true;
            btnIssue.Click += btnIssue_Click;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_321;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(745, 832);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(146, 48);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // labLicHistory
            // 
            labLicHistory.AutoSize = true;
            labLicHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labLicHistory.Location = new Point(14, 842);
            labLicHistory.Name = "labLicHistory";
            labLicHistory.Size = new Size(214, 28);
            labLicHistory.TabIndex = 5;
            labLicHistory.TabStop = true;
            labLicHistory.Text = "Show License History";
            labLicHistory.LinkClicked += labLicHistory_LinkClicked;
            // 
            // labNewLicenseInfo
            // 
            labNewLicenseInfo.AutoSize = true;
            labNewLicenseInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labNewLicenseInfo.Location = new Point(263, 842);
            labNewLicenseInfo.Name = "labNewLicenseInfo";
            labNewLicenseInfo.Size = new Size(231, 28);
            labNewLicenseInfo.TabIndex = 6;
            labNewLicenseInfo.TabStop = true;
            labNewLicenseInfo.Text = "Show New License Info";
            labNewLicenseInfo.LinkClicked += this.labNewLicenseInfo_LinkClicked;
            // 
            // ctrlFilterFindLicenseByLicid1
            // 
            ctrlFilterFindLicenseByLicid1.Location = new Point(16, 20);
            ctrlFilterFindLicenseByLicid1.Name = "ctrlFilterFindLicenseByLicid1";
            ctrlFilterFindLicenseByLicid1.Size = new Size(831, 108);
            ctrlFilterFindLicenseByLicid1.TabIndex = 7;
            // 
            // frmReplacementForDamagedLic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 887);
            Controls.Add(ctrlFilterFindLicenseByLicid1);
            Controls.Add(labNewLicenseInfo);
            Controls.Add(labLicHistory);
            Controls.Add(btnClose);
            Controls.Add(btnIssue);
            Controls.Add(ctrlDriverLicenseInfo1);
            Controls.Add(grbReplacementFor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmReplacementForDamagedLic";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Replacement For Damaged License";
            grbReplacementFor.ResumeLayout(false);
            grbReplacementFor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox grbReplacementFor;
        private RadioButton rbLostLic;
        private RadioButton rbDamagedLic;
        private ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private Button btnIssue;
        private Button btnClose;
        private LinkLabel labLicHistory;
        private LinkLabel labNewLicenseInfo;
        private ctrlFilterFindLicenseByLicID ctrlFilterFindLicenseByLicid1;
    }
}