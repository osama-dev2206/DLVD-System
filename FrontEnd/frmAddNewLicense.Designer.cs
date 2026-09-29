namespace FrontEnd
{
    partial class frmAddNewLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewLicense));
            ctrlLocalDrivingLicenseInfo1 = new ctrlLocalDrivingLicenseInfo();
            ctrlApplicationInfo1 = new CtrlApplicationInfo();
            tbNotes = new RichTextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnIssue = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ctrlLocalDrivingLicenseInfo1
            // 
            ctrlLocalDrivingLicenseInfo1.Location = new Point(21, 20);
            ctrlLocalDrivingLicenseInfo1.Name = "ctrlLocalDrivingLicenseInfo1";
            ctrlLocalDrivingLicenseInfo1.Size = new Size(519, 199);
            ctrlLocalDrivingLicenseInfo1.TabIndex = 0;
            // 
            // ctrlApplicationInfo1
            // 
            ctrlApplicationInfo1.Location = new Point(12, 225);
            ctrlApplicationInfo1.Name = "ctrlApplicationInfo1";
            ctrlApplicationInfo1.Size = new Size(744, 374);
            ctrlApplicationInfo1.TabIndex = 1;
            // 
            // tbNotes
            // 
            tbNotes.BackColor = Color.White;
            tbNotes.BorderStyle = BorderStyle.None;
            tbNotes.Location = new Point(103, 589);
            tbNotes.MaxLength = 500;
            tbNotes.Name = "tbNotes";
            tbNotes.Size = new Size(642, 116);
            tbNotes.TabIndex = 2;
            tbNotes.Text = "";
            tbNotes.TextChanged += tbNotes_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 602);
            label1.Name = "label1";
            label1.Size = new Size(77, 28);
            label1.TabIndex = 3;
            label1.Text = "Notes :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Notes_32;
            pictureBox1.Location = new Point(24, 646);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnIssue
            // 
            btnIssue.FlatAppearance.BorderSize = 2;
            btnIssue.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            btnIssue.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnIssue.FlatStyle = FlatStyle.Flat;
            btnIssue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnIssue.Image = Properties.Resources.IssueDrivingLicense_32;
            btnIssue.ImageAlign = ContentAlignment.BottomLeft;
            btnIssue.Location = new Point(605, 755);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(140, 44);
            btnIssue.TabIndex = 5;
            btnIssue.Text = "Issue";
            btnIssue.UseVisualStyleBackColor = true;
            btnIssue.Click += btnIssue_Click;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.BottomLeft;
            btnClose.Location = new Point(435, 755);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(140, 44);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmAddNewLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 811);
            Controls.Add(btnClose);
            Controls.Add(btnIssue);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(tbNotes);
            Controls.Add(ctrlApplicationInfo1);
            Controls.Add(ctrlLocalDrivingLicenseInfo1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddNewLicense";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New License";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlLocalDrivingLicenseInfo ctrlLocalDrivingLicenseInfo1;
        private CtrlApplicationInfo ctrlApplicationInfo1;
        private RichTextBox tbNotes;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnIssue;
        private Button btnClose;
    }
}