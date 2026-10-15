namespace FrontEnd
{
    partial class frmReleaseLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReleaseLicense));
            label1 = new Label();
            ctrlDriverLicenseInfo1 = new ctrlDriverLicenseInfo();
            ctrlFilterFindLicenseByLicid1 = new ctrlFilterFindLicenseByLicID();
            labLisHistory = new LinkLabel();
            labShowNewLicense = new LinkLabel();
            btnClose = new Button();
            btnRelease = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(343, 23);
            label1.Name = "label1";
            label1.Size = new Size(474, 54);
            label1.TabIndex = 0;
            label1.Text = "Release Detained License";
            // 
            // ctrlDriverLicenseInfo1
            // 
            ctrlDriverLicenseInfo1.Location = new Point(12, 191);
            ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            ctrlDriverLicenseInfo1.Size = new Size(1162, 419);
            ctrlDriverLicenseInfo1.TabIndex = 1;
            // 
            // ctrlFilterFindLicenseByLicid1
            // 
            ctrlFilterFindLicenseByLicid1.Location = new Point(224, 89);
            ctrlFilterFindLicenseByLicid1.Name = "ctrlFilterFindLicenseByLicid1";
            ctrlFilterFindLicenseByLicid1.Size = new Size(904, 96);
            ctrlFilterFindLicenseByLicid1.TabIndex = 2;
            // 
            // labLisHistory
            // 
            labLisHistory.AutoSize = true;
            labLisHistory.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labLisHistory.Location = new Point(12, 910);
            labLisHistory.Name = "labLisHistory";
            labLisHistory.Size = new Size(235, 31);
            labLisHistory.TabIndex = 3;
            labLisHistory.TabStop = true;
            labLisHistory.Text = "Show License History";
            labLisHistory.LinkClicked += labLisHistory_LinkClicked;
            // 
            // labShowNewLicense
            // 
            labShowNewLicense.AutoSize = true;
            labShowNewLicense.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labShowNewLicense.Location = new Point(253, 910);
            labShowNewLicense.Name = "labShowNewLicense";
            labShowNewLicense.Size = new Size(205, 31);
            labShowNewLicense.TabIndex = 4;
            labShowNewLicense.TabStop = true;
            labShowNewLicense.Text = "Show New License";
            labShowNewLicense.LinkClicked += labShowNewLicense_LinkClicked;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_321;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(810, 902);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(144, 46);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnRelease
            // 
            btnRelease.FlatAppearance.BorderSize = 2;
            btnRelease.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            btnRelease.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnRelease.FlatStyle = FlatStyle.Flat;
            btnRelease.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelease.Image = Properties.Resources.Release_Detained_License_321;
            btnRelease.ImageAlign = ContentAlignment.BottomLeft;
            btnRelease.Location = new Point(1001, 902);
            btnRelease.Name = "btnRelease";
            btnRelease.Size = new Size(153, 46);
            btnRelease.TabIndex = 6;
            btnRelease.Text = "Release";
            btnRelease.UseVisualStyleBackColor = true;
            btnRelease.Click += btnRelease_Click;
            // 
            // frmReleaseLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 954);
            Controls.Add(btnRelease);
            Controls.Add(btnClose);
            Controls.Add(labShowNewLicense);
            Controls.Add(labLisHistory);
            Controls.Add(ctrlFilterFindLicenseByLicid1);
            Controls.Add(ctrlDriverLicenseInfo1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmReleaseLicense";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Release License";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private ctrlFilterFindLicenseByLicID ctrlFilterFindLicenseByLicid1;
        private LinkLabel labLisHistory;
        private LinkLabel labShowNewLicense;
        private Button btnClose;
        private Button btnRelease;
    }
}