namespace FrontEnd
{
    partial class frmManageWrittenTestAppointments
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageWrittenTestAppointments));
            labCountOfRecords = new Label();
            label3 = new Label();
            btnClose = new Button();
            label2 = new Label();
            pbAdd = new PictureBox();
            DgvWrittenAppointments = new DataGridView();
            ctrlApplicationInfo1 = new CtrlApplicationInfo();
            ctrlLocalDrivingLicenseInfo2 = new ctrlLocalDrivingLicenseInfo();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            takeTestToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pbAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvWrittenAppointments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labCountOfRecords
            // 
            labCountOfRecords.AutoSize = true;
            labCountOfRecords.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labCountOfRecords.Location = new Point(182, 1148);
            labCountOfRecords.Name = "labCountOfRecords";
            labCountOfRecords.Size = new Size(27, 31);
            labCountOfRecords.TabIndex = 20;
            labCountOfRecords.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 1143);
            label3.Name = "label3";
            label3.Size = new Size(157, 38);
            label3.TabIndex = 19;
            label3.Text = "# Records :";
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 2;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.BottomLeft;
            btnClose.Location = new Point(941, 1136);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(177, 47);
            btnClose.TabIndex = 18;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 911);
            label2.Name = "label2";
            label2.Size = new Size(180, 31);
            label2.TabIndex = 17;
            label2.Text = "Appointments :";
            // 
            // pbAdd
            // 
            pbAdd.Image = Properties.Resources.AddAppointment_32;
            pbAdd.Location = new Point(1044, 882);
            pbAdd.Name = "pbAdd";
            pbAdd.Size = new Size(70, 60);
            pbAdd.SizeMode = PictureBoxSizeMode.Zoom;
            pbAdd.TabIndex = 16;
            pbAdd.TabStop = false;
            pbAdd.Click += pbAdd_Click;
            // 
            // DgvWrittenAppointments
            // 
            DgvWrittenAppointments.AllowUserToAddRows = false;
            DgvWrittenAppointments.AllowUserToDeleteRows = false;
            DgvWrittenAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvWrittenAppointments.BackgroundColor = Color.FromArgb(224, 224, 224);
            DgvWrittenAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvWrittenAppointments.Location = new Point(12, 946);
            DgvWrittenAppointments.Name = "DgvWrittenAppointments";
            DgvWrittenAppointments.ReadOnly = true;
            DgvWrittenAppointments.RowHeadersWidth = 51;
            DgvWrittenAppointments.Size = new Size(1107, 172);
            DgvWrittenAppointments.TabIndex = 15;
            DgvWrittenAppointments.SelectionChanged += DGVAppointmentsSelectionChanged;
            // 
            // ctrlApplicationInfo1
            // 
            ctrlApplicationInfo1.Location = new Point(13, 522);
            ctrlApplicationInfo1.Name = "ctrlApplicationInfo1";
            ctrlApplicationInfo1.Size = new Size(1096, 358);
            ctrlApplicationInfo1.TabIndex = 14;
            // 
            // ctrlLocalDrivingLicenseInfo2
            // 
            ctrlLocalDrivingLicenseInfo2.Location = new Point(13, 322);
            ctrlLocalDrivingLicenseInfo2.Name = "ctrlLocalDrivingLicenseInfo2";
            ctrlLocalDrivingLicenseInfo2.Size = new Size(1067, 194);
            ctrlLocalDrivingLicenseInfo2.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(209, 236);
            label1.Name = "label1";
            label1.Size = new Size(744, 81);
            label1.TabIndex = 12;
            label1.Text = "Written Test Appointment";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Written_Test_512;
            pictureBox1.Location = new Point(415, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(292, 193);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, takeTestToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(142, 56);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(141, 26);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // takeTestToolStripMenuItem
            // 
            takeTestToolStripMenuItem.Image = Properties.Resources.Test_321;
            takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            takeTestToolStripMenuItem.Size = new Size(141, 26);
            takeTestToolStripMenuItem.Text = "Take Test";
            takeTestToolStripMenuItem.Click += takeTestToolStripMenuItem_Click;
            // 
            // frmManageWrittenTestAppointments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 1198);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(labCountOfRecords);
            Controls.Add(label3);
            Controls.Add(btnClose);
            Controls.Add(label2);
            Controls.Add(pbAdd);
            Controls.Add(DgvWrittenAppointments);
            Controls.Add(ctrlApplicationInfo1);
            Controls.Add(ctrlLocalDrivingLicenseInfo2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmManageWrittenTestAppointments";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Manage Written Test Appointments";
            ((System.ComponentModel.ISupportInitialize)pbAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvWrittenAppointments).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labCountOfRecords;
        private Label label3;
        private Button btnClose;
        private Label label2;
        private PictureBox pbAdd;
        private DataGridView DgvWrittenAppointments;
        private CtrlApplicationInfo ctrlApplicationInfo1;
        private ctrlLocalDrivingLicenseInfo ctrlLocalDrivingLicenseInfo2;
        private Label label1;
        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem takeTestToolStripMenuItem;
    }
}