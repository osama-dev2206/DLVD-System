namespace FrontEnd
{
    partial class frmAddNewAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewAppointment));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ctrlScheduleTestInfo1 = new ctrlScheduleTestInfo();
            btnSave = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Vision_512;
            pictureBox1.Location = new Point(175, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(105, 189);
            label1.Name = "label1";
            label1.Size = new Size(328, 62);
            label1.TabIndex = 1;
            label1.Text = "Schedule Test ";
            // 
            // ctrlScheduleTestInfo1
            // 
            ctrlScheduleTestInfo1.Location = new Point(32, 266);
            ctrlScheduleTestInfo1.Name = "ctrlScheduleTestInfo1";
            ctrlScheduleTestInfo1.Size = new Size(483, 335);
            ctrlScheduleTestInfo1.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(387, 632);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(143, 41);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(220, 632);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(143, 41);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmAddNewAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 690);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(ctrlScheduleTestInfo1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddNewAppointment";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New Appointment";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ctrlScheduleTestInfo ctrlScheduleTestInfo1;
        private Button btnSave;
        private Button btnClose;
    }
}