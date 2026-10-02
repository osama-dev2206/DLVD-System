namespace FrontEnd
{
    partial class frmNewInternationalLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewInternationalLicense));
            ctrlDriverInfo1 = new ctrlDriverInfo();
            btnIssue = new Button();
            btnClose = new Button();
            labLicenseHistory = new LinkLabel();
            labLicenseInfo = new LinkLabel();
            SuspendLayout();
            // 
            // ctrlDriverInfo1
            // 
            ctrlDriverInfo1.Location = new Point(33, 105);
            ctrlDriverInfo1.Name = "ctrlDriverInfo1";
            ctrlDriverInfo1.Size = new Size(900, 408);
            ctrlDriverInfo1.TabIndex = 0;
            // 
            // btnIssue
            // 
            btnIssue.FlatAppearance.BorderSize = 2;
            btnIssue.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            btnIssue.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnIssue.FlatStyle = FlatStyle.Flat;
            btnIssue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIssue.Image = Properties.Resources.IssueDrivingLicense_321;
            btnIssue.ImageAlign = ContentAlignment.BottomLeft;
            btnIssue.Location = new Point(799, 900);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(164, 45);
            btnIssue.TabIndex = 2;
            btnIssue.Text = "Issue";
            btnIssue.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.BottomLeft;
            btnClose.Location = new Point(611, 900);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(164, 45);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // labLicenseHistory
            // 
            labLicenseHistory.AutoSize = true;
            labLicenseHistory.Font = new Font("Segoe UI", 13.8F);
            labLicenseHistory.Location = new Point(20, 907);
            labLicenseHistory.Name = "labLicenseHistory";
            labLicenseHistory.Size = new Size(228, 31);
            labLicenseHistory.TabIndex = 4;
            labLicenseHistory.TabStop = true;
            labLicenseHistory.Text = "Show License History";
            // 
            // labLicenseInfo
            // 
            labLicenseInfo.AutoSize = true;
            labLicenseInfo.Font = new Font("Segoe UI", 13.8F);
            labLicenseInfo.Location = new Point(263, 907);
            labLicenseInfo.Name = "labLicenseInfo";
            labLicenseInfo.Size = new Size(195, 31);
            labLicenseInfo.TabIndex = 5;
            labLicenseInfo.TabStop = true;
            labLicenseInfo.Text = "Show License Info";
            // 
            // frmNewInternationalLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 950);
            Controls.Add(labLicenseInfo);
            Controls.Add(labLicenseHistory);
            Controls.Add(btnClose);
            Controls.Add(btnIssue);
            Controls.Add(ctrlDriverInfo1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmNewInternationalLicense";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "New International License";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlDriverInfo ctrlDriverInfo1;
        private Button btnIssue;
        private Button btnClose;
        private LinkLabel labLicenseHistory;
        private LinkLabel labLicenseInfo;
    }
}