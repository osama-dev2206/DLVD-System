namespace FrontEnd
{
    partial class frmRenewLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRenewLicense));
            btnClose = new Button();
            label1 = new Label();
            ctrlFilterFindLicenseByLicid1 = new ctrlFilterFindLicenseByLicID();
            ctrlDriverInfo1 = new ctrlDriverLicenseInfo();
            btnRenew = new Button();
            labShowLicenseHistory = new LinkLabel();
            labNewLicenseInfo = new LinkLabel();
            ctrlRenewApplicationInfo1 = new ctrlRenewApplicationInfo();
            tbNotes = new RichTextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(819, 1216);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(156, 49);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(330, 18);
            label1.Name = "label1";
            label1.Size = new Size(501, 54);
            label1.TabIndex = 1;
            label1.Text = "Renew License Application";
            // 
            // ctrlFilterFindLicenseByLicid1
            // 
            ctrlFilterFindLicenseByLicid1.Location = new Point(242, 86);
            ctrlFilterFindLicenseByLicid1.Name = "ctrlFilterFindLicenseByLicid1";
            ctrlFilterFindLicenseByLicid1.Size = new Size(658, 122);
            ctrlFilterFindLicenseByLicid1.TabIndex = 2;
            // 
            // ctrlDriverInfo1
            // 
            ctrlDriverInfo1.Location = new Point(20, 192);
            ctrlDriverInfo1.Name = "ctrlDriverInfo1";
            ctrlDriverInfo1.Size = new Size(1137, 401);
            ctrlDriverInfo1.TabIndex = 3;
            // 
            // btnRenew
            // 
            btnRenew.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            btnRenew.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnRenew.FlatStyle = FlatStyle.Flat;
            btnRenew.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRenew.Image = Properties.Resources.Renew_Driving_License_322;
            btnRenew.ImageAlign = ContentAlignment.MiddleLeft;
            btnRenew.Location = new Point(1001, 1216);
            btnRenew.Name = "btnRenew";
            btnRenew.Size = new Size(156, 49);
            btnRenew.TabIndex = 4;
            btnRenew.Text = "Renew";
            btnRenew.UseVisualStyleBackColor = true;
            btnRenew.Click += Renew_Click;
            // 
            // labShowLicenseHistory
            // 
            labShowLicenseHistory.AutoSize = true;
            labShowLicenseHistory.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labShowLicenseHistory.Location = new Point(17, 1225);
            labShowLicenseHistory.Name = "labShowLicenseHistory";
            labShowLicenseHistory.Size = new Size(235, 31);
            labShowLicenseHistory.TabIndex = 5;
            labShowLicenseHistory.TabStop = true;
            labShowLicenseHistory.Text = "Show License History";
            labShowLicenseHistory.LinkClicked += labShowLicenseHistory_LinkClicked;
            // 
            // labNewLicenseInfo
            // 
            labNewLicenseInfo.AutoSize = true;
            labNewLicenseInfo.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labNewLicenseInfo.Location = new Point(271, 1225);
            labNewLicenseInfo.Name = "labNewLicenseInfo";
            labNewLicenseInfo.Size = new Size(253, 31);
            labNewLicenseInfo.TabIndex = 6;
            labNewLicenseInfo.TabStop = true;
            labNewLicenseInfo.Text = "Show New License Info";
            labNewLicenseInfo.LinkClicked += labNewLicenseInfo_LinkClicked;
            // 
            // ctrlRenewApplicationInfo1
            // 
            ctrlRenewApplicationInfo1.Location = new Point(12, 928);
            ctrlRenewApplicationInfo1.Name = "ctrlRenewApplicationInfo1";
            ctrlRenewApplicationInfo1.Size = new Size(1088, 186);
            ctrlRenewApplicationInfo1.TabIndex = 8;
            // 
            // tbNotes
            // 
            tbNotes.BorderStyle = BorderStyle.None;
            tbNotes.Location = new Point(168, 1120);
            tbNotes.MaxLength = 500;
            tbNotes.Name = "tbNotes";
            tbNotes.Size = new Size(596, 86);
            tbNotes.TabIndex = 9;
            tbNotes.Text = "";
            tbNotes.TextChanged += tbNotes_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 1138);
            label2.Name = "label2";
            label2.Size = new Size(77, 31);
            label2.TabIndex = 10;
            label2.Text = "Notes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Notes_32;
            pictureBox1.Location = new Point(97, 1134);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(505, 596);
            label3.Name = "label3";
            label3.Size = new Size(656, 20);
            label3.TabIndex = 12;
            label3.Text = "** Please note App Info Will Be Updated After Renewing License To New Info And Driver Info Also";
            // 
            // frmRenewLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 1277);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(tbNotes);
            Controls.Add(ctrlRenewApplicationInfo1);
            Controls.Add(labNewLicenseInfo);
            Controls.Add(labShowLicenseHistory);
            Controls.Add(btnRenew);
            Controls.Add(ctrlDriverInfo1);
            Controls.Add(ctrlFilterFindLicenseByLicid1);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRenewLicense";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Renew License";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label label1;
        private ctrlFilterFindLicenseByLicID ctrlFilterFindLicenseByLicid1;
        private ctrlDriverLicenseInfo ctrlDriverInfo1;
        private Button btnRenew;
        private LinkLabel labShowLicenseHistory;
        private LinkLabel labNewLicenseInfo;
        private ctrlRenewApplicationInfo ctrlRenewApplicationInfo1;
        private RichTextBox tbNotes;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
    }
}