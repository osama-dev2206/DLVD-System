namespace FrontEnd
{
    partial class frmAddEditAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditAppointment));
            pbStatusOfForm = new PictureBox();
            labFormStatus = new Label();
            ctrlScheduleTestInfo1 = new ctrlScheduleTestInfo();
            btnSave = new Button();
            btnClose = new Button();
            ctrlRetakeTestInfo1 = new ctrlRetakeTestInfo();
            ((System.ComponentModel.ISupportInitialize)pbStatusOfForm).BeginInit();
            SuspendLayout();
            // 
            // pbStatusOfForm
            // 
            pbStatusOfForm.Image = Properties.Resources.Vision_512;
            pbStatusOfForm.Location = new Point(136, 12);
            pbStatusOfForm.Name = "pbStatusOfForm";
            pbStatusOfForm.Size = new Size(330, 134);
            pbStatusOfForm.SizeMode = PictureBoxSizeMode.Zoom;
            pbStatusOfForm.TabIndex = 0;
            pbStatusOfForm.TabStop = false;
            // 
            // labFormStatus
            // 
            labFormStatus.AutoSize = true;
            labFormStatus.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labFormStatus.ForeColor = Color.Red;
            labFormStatus.Location = new Point(136, 173);
            labFormStatus.Name = "labFormStatus";
            labFormStatus.Size = new Size(278, 54);
            labFormStatus.TabIndex = 1;
            labFormStatus.Text = "Schedule Test ";
            // 
            // ctrlScheduleTestInfo1
            // 
            ctrlScheduleTestInfo1.Location = new Point(68, 230);
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
            btnSave.Location = new Point(360, 720);
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
            btnClose.Location = new Point(146, 720);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(143, 41);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ctrlRetakeTestInfo1
            // 
            ctrlRetakeTestInfo1.Location = new Point(4, 553);
            ctrlRetakeTestInfo1.Name = "ctrlRetakeTestInfo1";
            ctrlRetakeTestInfo1.Size = new Size(621, 120);
            ctrlRetakeTestInfo1.TabIndex = 6;
            // 
            // frmAddEditAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 773);
            Controls.Add(ctrlRetakeTestInfo1);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(ctrlScheduleTestInfo1);
            Controls.Add(labFormStatus);
            Controls.Add(pbStatusOfForm);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddEditAppointment";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add/Edit New Appointment";
            ((System.ComponentModel.ISupportInitialize)pbStatusOfForm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbStatusOfForm;
        private Label labFormStatus;
        private ctrlScheduleTestInfo ctrlScheduleTestInfo1;
        private Button btnSave;
        private Button btnClose;
        private ctrlRetakeTestInfo ctrlRetakeTestInfo1;
    }
}