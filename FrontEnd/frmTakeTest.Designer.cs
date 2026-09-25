namespace FrontEnd
{
    partial class frmTakeTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTakeTest));
            ctrlScheduleTestInfo1 = new ctrlScheduleTestInfo();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            rbPass = new RadioButton();
            label2 = new Label();
            labTestID = new Label();
            pictureBox2 = new PictureBox();
            rbFail = new RadioButton();
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtNotes = new RichTextBox();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            btnSave = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // ctrlScheduleTestInfo1
            // 
            ctrlScheduleTestInfo1.Location = new Point(122, 187);
            ctrlScheduleTestInfo1.Name = "ctrlScheduleTestInfo1";
            ctrlScheduleTestInfo1.Size = new Size(557, 220);
            ctrlScheduleTestInfo1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Vision_Test_32;
            pictureBox1.Location = new Point(307, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(315, 134);
            label1.Name = "label1";
            label1.Size = new Size(170, 50);
            label1.TabIndex = 2;
            label1.Text = "Take Test";
            // 
            // rbPass
            // 
            rbPass.AutoSize = true;
            rbPass.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbPass.Location = new Point(127, 30);
            rbPass.Name = "rbPass";
            rbPass.Size = new Size(64, 27);
            rbPass.TabIndex = 3;
            rbPass.TabStop = true;
            rbPass.Text = "Pass";
            rbPass.UseVisualStyleBackColor = true;
            rbPass.Click += rb_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(142, 410);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 4;
            label2.Text = "Test ID : ";
            // 
            // labTestID
            // 
            labTestID.AutoSize = true;
            labTestID.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labTestID.Location = new Point(265, 410);
            labTestID.Name = "labTestID";
            labTestID.Size = new Size(24, 23);
            labTestID.TabIndex = 5;
            labTestID.Text = "-1";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Number_32;
            pictureBox2.Location = new Point(213, 403);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // rbFail
            // 
            rbFail.AutoSize = true;
            rbFail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbFail.Location = new Point(300, 30);
            rbFail.Name = "rbFail";
            rbFail.Size = new Size(56, 27);
            rbFail.TabIndex = 7;
            rbFail.TabStop = true;
            rbFail.Text = "Fail";
            rbFail.UseVisualStyleBackColor = true;
            rbFail.Click += rb_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(rbFail);
            groupBox1.Controls.Add(rbPass);
            groupBox1.Location = new Point(15, 442);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(766, 78);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 31);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 8;
            label3.Text = "Result :";
            // 
            // txtNotes
            // 
            txtNotes.BorderStyle = BorderStyle.None;
            txtNotes.Location = new Point(101, 526);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(680, 78);
            txtNotes.TabIndex = 9;
            txtNotes.Text = "";
            txtNotes.TextChanged += Notes_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 526);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 10;
            label4.Text = "Notes :";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Notes_32;
            pictureBox3.Location = new Point(22, 554);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 53);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.BottomLeft;
            btnSave.Location = new Point(658, 626);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 40);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_321;
            btnClose.ImageAlign = ContentAlignment.BottomLeft;
            btnClose.Location = new Point(500, 626);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(135, 40);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmTakeTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 671);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(pictureBox3);
            Controls.Add(label4);
            Controls.Add(txtNotes);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox2);
            Controls.Add(labTestID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(ctrlScheduleTestInfo1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTakeTest";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Take Test";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlScheduleTestInfo ctrlScheduleTestInfo1;
        private PictureBox pictureBox1;
        private Label label1;
        private RadioButton rbPass;
        private Label label2;
        private Label labTestID;
        private PictureBox pictureBox2;
        private RadioButton rbFail;
        private GroupBox groupBox1;
        private RichTextBox txtNotes;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox3;
        private Button btnSave;
        private Button btnClose;
    }
}