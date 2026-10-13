namespace FrontEnd
{
    partial class frmDetainLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetainLicense));
            ctrlFilterFindLicenseByLicid1 = new ctrlFilterFindLicenseByLicID();
            label1 = new Label();
            ctrlDriverLicenseInfo1 = new ctrlDriverLicenseInfo();
            labLicenseHistory = new LinkLabel();
            labShowLic = new LinkLabel();
            btnClose = new Button();
            btnDetain = new Button();
            SuspendLayout();
            // 
            // ctrlFilterFindLicenseByLicid1
            // 
            ctrlFilterFindLicenseByLicid1.Location = new Point(212, 85);
            ctrlFilterFindLicenseByLicid1.Name = "ctrlFilterFindLicenseByLicid1";
            ctrlFilterFindLicenseByLicid1.Size = new Size(799, 89);
            ctrlFilterFindLicenseByLicid1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(419, 22);
            label1.Name = "label1";
            label1.Size = new Size(315, 60);
            label1.TabIndex = 1;
            label1.Text = "Detain License";
            // 
            // ctrlDriverLicenseInfo1
            // 
            ctrlDriverLicenseInfo1.Location = new Point(7, 172);
            ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            ctrlDriverLicenseInfo1.Size = new Size(1180, 412);
            ctrlDriverLicenseInfo1.TabIndex = 2;
            // 
            // labLicenseHistory
            // 
            labLicenseHistory.AutoSize = true;
            labLicenseHistory.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labLicenseHistory.Location = new Point(19, 815);
            labLicenseHistory.Name = "labLicenseHistory";
            labLicenseHistory.Size = new Size(235, 31);
            labLicenseHistory.TabIndex = 3;
            labLicenseHistory.TabStop = true;
            labLicenseHistory.Text = "Show License History";
            labLicenseHistory.LinkClicked += labLicenseHistory_LinkClicked;
            // 
            // labShowLic
            // 
            labShowLic.AutoSize = true;
            labShowLic.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labShowLic.Location = new Point(260, 815);
            labShowLic.Name = "labShowLic";
            labShowLic.Size = new Size(253, 31);
            labShowLic.TabIndex = 4;
            labShowLic.TabStop = true;
            labShowLic.Text = "Show New License Info";
            labShowLic.LinkClicked += labShowLic_LinkClicked;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_322;
            btnClose.ImageAlign = ContentAlignment.BottomLeft;
            btnClose.Location = new Point(839, 809);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(151, 42);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDetain
            // 
            btnDetain.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            btnDetain.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            btnDetain.FlatStyle = FlatStyle.Flat;
            btnDetain.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetain.Image = Properties.Resources.Detain_32;
            btnDetain.ImageAlign = ContentAlignment.BottomLeft;
            btnDetain.Location = new Point(1022, 809);
            btnDetain.Name = "btnDetain";
            btnDetain.Size = new Size(151, 42);
            btnDetain.TabIndex = 6;
            btnDetain.Text = "Detain";
            btnDetain.UseVisualStyleBackColor = true;
            // 
            // frmDetainLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 858);
            Controls.Add(btnDetain);
            Controls.Add(btnClose);
            Controls.Add(labShowLic);
            Controls.Add(labLicenseHistory);
            Controls.Add(ctrlDriverLicenseInfo1);
            Controls.Add(label1);
            Controls.Add(ctrlFilterFindLicenseByLicid1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmDetainLicense";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Detain License";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlFilterFindLicenseByLicID ctrlFilterFindLicenseByLicid1;
        private Label label1;
        private ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private LinkLabel labLicenseHistory;
        private LinkLabel labShowLic;
        private Button btnClose;
        private Button btnDetain;
    }
}