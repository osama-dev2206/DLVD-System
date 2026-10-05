namespace FrontEnd
{
    partial class ctrlRenewApplicationInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            labOldLicID = new Label();
            labNewLicID = new Label();
            labExpDate = new Label();
            labIssueDate = new Label();
            labLicFees = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 41);
            label1.Name = "label1";
            label1.Size = new Size(133, 23);
            label1.TabIndex = 0;
            label1.Text = "Old License ID : ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labLicFees);
            groupBox1.Controls.Add(labIssueDate);
            groupBox1.Controls.Add(labExpDate);
            groupBox1.Controls.Add(labNewLicID);
            groupBox1.Controls.Add(labOldLicID);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(760, 170);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Renew Info";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Calendar_32;
            pictureBox3.Location = new Point(497, 102);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.money_321;
            pictureBox2.Location = new Point(521, 63);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Calendar_32;
            pictureBox1.Location = new Point(109, 137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(402, 102);
            label5.Name = "label5";
            label5.Size = new Size(98, 23);
            label5.TabIndex = 4;
            label5.Text = "Issue Date :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(402, 63);
            label4.Name = "label4";
            label4.Size = new Size(113, 23);
            label4.TabIndex = 3;
            label4.Text = "License Fees :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 137);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 2;
            label3.Text = "ExpDate : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 89);
            label2.Name = "label2";
            label2.Size = new Size(141, 23);
            label2.TabIndex = 1;
            label2.Text = "New License ID : ";
            // 
            // labOldLicID
            // 
            labOldLicID.AutoSize = true;
            labOldLicID.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labOldLicID.Location = new Point(170, 41);
            labOldLicID.Name = "labOldLicID";
            labOldLicID.Size = new Size(24, 23);
            labOldLicID.TabIndex = 8;
            labOldLicID.Text = "??";
            // 
            // labNewLicID
            // 
            labNewLicID.AutoSize = true;
            labNewLicID.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labNewLicID.Location = new Point(170, 89);
            labNewLicID.Name = "labNewLicID";
            labNewLicID.Size = new Size(24, 23);
            labNewLicID.TabIndex = 9;
            labNewLicID.Text = "??";
            // 
            // labExpDate
            // 
            labExpDate.AutoSize = true;
            labExpDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labExpDate.Location = new Point(156, 137);
            labExpDate.Name = "labExpDate";
            labExpDate.Size = new Size(24, 23);
            labExpDate.TabIndex = 10;
            labExpDate.Text = "??";
            // 
            // labIssueDate
            // 
            labIssueDate.AutoSize = true;
            labIssueDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labIssueDate.Location = new Point(544, 102);
            labIssueDate.Name = "labIssueDate";
            labIssueDate.Size = new Size(24, 23);
            labIssueDate.TabIndex = 11;
            labIssueDate.Text = "??";
            // 
            // labLicFees
            // 
            labLicFees.AutoSize = true;
            labLicFees.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labLicFees.Location = new Point(568, 63);
            labLicFees.Name = "labLicFees";
            labLicFees.Size = new Size(24, 23);
            labLicFees.TabIndex = 12;
            labLicFees.Text = "??";
            // 
            // ctrlRenewApplicationInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "ctrlRenewApplicationInfo";
            Size = new Size(809, 201);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label labOldLicID;
        private Label labNewLicID;
        private Label labExpDate;
        private Label labIssueDate;
        private Label labLicFees;
    }
}
