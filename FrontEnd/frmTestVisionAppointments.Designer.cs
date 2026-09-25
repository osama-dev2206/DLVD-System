namespace FrontEnd
{
    partial class frmTestVisionAppointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTestVisionAppointments));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ctrlLocalDrivingLicenseInfo2 = new ctrlLocalDrivingLicenseInfo();
            ctrlApplicationInfo1 = new CtrlApplicationInfo();
            DgvVisionAppointments = new DataGridView();
            pbAdd = new PictureBox();
            label2 = new Label();
            btnClose = new Button();
            label3 = new Label();
            labCountOfRecords = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            takeTestToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvVisionAppointments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAdd).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Vision_512;
            pictureBox1.Location = new Point(414, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(292, 193);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(208, 250);
            label1.Name = "label1";
            label1.Size = new Size(704, 81);
            label1.TabIndex = 1;
            label1.Text = "Vision Test Appointment";
            // 
            // ctrlLocalDrivingLicenseInfo2
            // 
            ctrlLocalDrivingLicenseInfo2.Location = new Point(12, 336);
            ctrlLocalDrivingLicenseInfo2.Name = "ctrlLocalDrivingLicenseInfo2";
            ctrlLocalDrivingLicenseInfo2.Size = new Size(1067, 194);
            ctrlLocalDrivingLicenseInfo2.TabIndex = 3;
            // 
            // ctrlApplicationInfo1
            // 
            ctrlApplicationInfo1.Location = new Point(12, 536);
            ctrlApplicationInfo1.Name = "ctrlApplicationInfo1";
            ctrlApplicationInfo1.Size = new Size(1096, 358);
            ctrlApplicationInfo1.TabIndex = 4;
            // 
            // DgvVisionAppointments
            // 
            DgvVisionAppointments.AllowUserToAddRows = false;
            DgvVisionAppointments.AllowUserToDeleteRows = false;
            DgvVisionAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvVisionAppointments.BackgroundColor = Color.FromArgb(224, 224, 224);
            DgvVisionAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvVisionAppointments.Location = new Point(11, 960);
            DgvVisionAppointments.Name = "DgvVisionAppointments";
            DgvVisionAppointments.ReadOnly = true;
            DgvVisionAppointments.RowHeadersWidth = 51;
            DgvVisionAppointments.Size = new Size(1107, 172);
            DgvVisionAppointments.TabIndex = 5;
            DgvVisionAppointments.SelectionChanged += DGVUsersSelectionChanged;
            // 
            // pbAdd
            // 
            pbAdd.Image = Properties.Resources.AddAppointment_32;
            pbAdd.Location = new Point(1043, 896);
            pbAdd.Name = "pbAdd";
            pbAdd.Size = new Size(70, 60);
            pbAdd.SizeMode = PictureBoxSizeMode.Zoom;
            pbAdd.TabIndex = 6;
            pbAdd.TabStop = false;
            pbAdd.Click += pbAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 925);
            label2.Name = "label2";
            label2.Size = new Size(180, 31);
            label2.TabIndex = 7;
            label2.Text = "Appointments :";
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 2;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.BottomLeft;
            btnClose.Location = new Point(940, 1150);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(177, 47);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 1157);
            label3.Name = "label3";
            label3.Size = new Size(157, 38);
            label3.TabIndex = 9;
            label3.Text = "# Records :";
            // 
            // labCountOfRecords
            // 
            labCountOfRecords.AutoSize = true;
            labCountOfRecords.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labCountOfRecords.Location = new Point(181, 1166);
            labCountOfRecords.Name = "labCountOfRecords";
            labCountOfRecords.Size = new Size(23, 28);
            labCountOfRecords.TabIndex = 10;
            labCountOfRecords.Text = "0";
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
            // frmTestVisionAppointments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 1204);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(labCountOfRecords);
            Controls.Add(label3);
            Controls.Add(btnClose);
            Controls.Add(label2);
            Controls.Add(pbAdd);
            Controls.Add(DgvVisionAppointments);
            Controls.Add(ctrlApplicationInfo1);
            Controls.Add(ctrlLocalDrivingLicenseInfo2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTestVisionAppointments";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Vision Test Appointments";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvVisionAppointments).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAdd).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ctrlLocalDrivingLicenseInfo ctrlLocalDrivingLicenseInfo2;
        private CtrlApplicationInfo ctrlApplicationInfo1;
        private DataGridView DgvVisionAppointments;
        private PictureBox pbAdd;
        private Label label2;
        private Button btnClose;
        private Label label3;
        private Label labCountOfRecords;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem takeTestToolStripMenuItem;
    }
}