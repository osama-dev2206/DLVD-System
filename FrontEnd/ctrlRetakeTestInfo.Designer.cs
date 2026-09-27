namespace FrontEnd
{
    partial class ctrlRetakeTestInfo
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
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            labApplicationFees = new Label();
            labRetakeApplicationID = new Label();
            labTotalFees = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 28);
            label1.Name = "label1";
            label1.Size = new Size(202, 23);
            label1.TabIndex = 0;
            label1.Text = "Retake Application Fees :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 62);
            label2.Name = "label2";
            label2.Size = new Size(190, 23);
            label2.TabIndex = 1;
            label2.Text = "Retake Application ID : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(384, 27);
            label3.Name = "label3";
            label3.Size = new Size(94, 23);
            label3.TabIndex = 2;
            label3.Text = "Total Fees :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.money_32;
            pictureBox1.Location = new Point(210, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Number_32;
            pictureBox2.Location = new Point(204, 62);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.money_32;
            pictureBox3.Location = new Point(484, 27);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // labApplicationFees
            // 
            labApplicationFees.AutoSize = true;
            labApplicationFees.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labApplicationFees.Location = new Point(265, 29);
            labApplicationFees.Name = "labApplicationFees";
            labApplicationFees.Size = new Size(18, 20);
            labApplicationFees.TabIndex = 6;
            labApplicationFees.Text = "0";
            // 
            // labRetakeApplicationID
            // 
            labRetakeApplicationID.AutoSize = true;
            labRetakeApplicationID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labRetakeApplicationID.Location = new Point(253, 63);
            labRetakeApplicationID.Name = "labRetakeApplicationID";
            labRetakeApplicationID.Size = new Size(24, 20);
            labRetakeApplicationID.TabIndex = 7;
            labRetakeApplicationID.Text = "-1";
            // 
            // labTotalFees
            // 
            labTotalFees.AutoSize = true;
            labTotalFees.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labTotalFees.Location = new Point(537, 28);
            labTotalFees.Name = "labTotalFees";
            labTotalFees.Size = new Size(18, 20);
            labTotalFees.TabIndex = 8;
            labTotalFees.Text = "0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labTotalFees);
            groupBox1.Controls.Add(labRetakeApplicationID);
            groupBox1.Controls.Add(labApplicationFees);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(17, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(592, 98);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Retake Test Info";
            // 
            // ctrlRetakeTestInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "ctrlRetakeTestInfo";
            Size = new Size(649, 115);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label labApplicationFees;
        private Label labRetakeApplicationID;
        private Label labTotalFees;
        private GroupBox groupBox1;
    }
}
