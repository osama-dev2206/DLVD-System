namespace FrontEnd
{
    partial class frmManageLocalDrivingLicenseApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageLocalDrivingLicenseApplications));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            DgvLocal = new DataGridView();
            cbFilter = new ComboBox();
            labGF = new Label();
            pbAddNew = new PictureBox();
            btnClose = new Button();
            label2 = new Label();
            labCountOfRecords = new Label();
            tbSearchBy = new TextBox();
            cbStatus = new ComboBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showApplicationDetailsToolStripMenuItem = new ToolStripMenuItem();
            editApplicationToolStripMenuItem = new ToolStripMenuItem();
            deleteApplicationToolStripMenuItem = new ToolStripMenuItem();
            cancxToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvLocal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAddNew).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Application_Types_5121;
            pictureBox1.Location = new Point(512, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 245);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(350, 251);
            label1.Name = "label1";
            label1.Size = new Size(572, 46);
            label1.TabIndex = 1;
            label1.Text = "Local Driving License  Applications";
            // 
            // DgvLocal
            // 
            DgvLocal.AllowUserToAddRows = false;
            DgvLocal.AllowUserToDeleteRows = false;
            DgvLocal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvLocal.BackgroundColor = Color.FromArgb(224, 224, 224);
            DgvLocal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvLocal.Location = new Point(12, 416);
            DgvLocal.Name = "DgvLocal";
            DgvLocal.ReadOnly = true;
            DgvLocal.RowHeadersWidth = 51;
            DgvLocal.Size = new Size(1257, 302);
            DgvLocal.TabIndex = 2;
            DgvLocal.SelectionChanged += DGVLocalSelectionChanged;
            // 
            // cbFilter
            // 
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "None", "L.D.L App ID", "National No", "Full Name", "Status" });
            cbFilter.Location = new Point(141, 365);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(168, 28);
            cbFilter.TabIndex = 3;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // labGF
            // 
            labGF.AutoSize = true;
            labGF.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labGF.Location = new Point(12, 359);
            labGF.Name = "labGF";
            labGF.Size = new Size(111, 31);
            labGF.TabIndex = 4;
            labGF.Text = "Filter By :";
            // 
            // pbAddNew
            // 
            pbAddNew.Image = Properties.Resources.New_Application_64;
            pbAddNew.Location = new Point(1164, 338);
            pbAddNew.Name = "pbAddNew";
            pbAddNew.Size = new Size(90, 72);
            pbAddNew.SizeMode = PictureBoxSizeMode.Zoom;
            pbAddNew.TabIndex = 5;
            pbAddNew.TabStop = false;
            pbAddNew.Click += pbAddNew_Click;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(1065, 726);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(204, 49);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 737);
            label2.Name = "label2";
            label2.Size = new Size(179, 41);
            label2.TabIndex = 7;
            label2.Text = "#  Records :";
            // 
            // labCountOfRecords
            // 
            labCountOfRecords.AutoSize = true;
            labCountOfRecords.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labCountOfRecords.Location = new Point(197, 744);
            labCountOfRecords.Name = "labCountOfRecords";
            labCountOfRecords.Size = new Size(27, 31);
            labCountOfRecords.TabIndex = 8;
            labCountOfRecords.Text = "0";
            // 
            // tbSearchBy
            // 
            tbSearchBy.Location = new Point(350, 361);
            tbSearchBy.Name = "tbSearchBy";
            tbSearchBy.Size = new Size(291, 27);
            tbSearchBy.TabIndex = 9;
            tbSearchBy.TextChanged += tbSearchBy_TextChanged;
            tbSearchBy.KeyPress += tbSearchBy_KeyPress;
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "New", "Cancelled", "Completed" });
            cbStatus.Location = new Point(350, 362);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(168, 28);
            cbStatus.TabIndex = 10;
            cbStatus.SelectedIndexChanged += cbStatus_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showApplicationDetailsToolStripMenuItem, editApplicationToolStripMenuItem, deleteApplicationToolStripMenuItem, cancxToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(250, 108);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            showApplicationDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            showApplicationDetailsToolStripMenuItem.Size = new Size(249, 26);
            showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            showApplicationDetailsToolStripMenuItem.Click += showApplicationDetailsToolStripMenuItem_Click;
            // 
            // editApplicationToolStripMenuItem
            // 
            editApplicationToolStripMenuItem.Image = Properties.Resources.edit_321;
            editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            editApplicationToolStripMenuItem.Size = new Size(249, 26);
            editApplicationToolStripMenuItem.Text = "Edit Application";
            editApplicationToolStripMenuItem.Click += editApplicationToolStripMenuItem_Click;
            // 
            // deleteApplicationToolStripMenuItem
            // 
            deleteApplicationToolStripMenuItem.Image = Properties.Resources.Delete_32_2;
            deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            deleteApplicationToolStripMenuItem.Size = new Size(249, 26);
            deleteApplicationToolStripMenuItem.Text = "Delete Application";
            deleteApplicationToolStripMenuItem.Click += deleteApplicationToolStripMenuItem_Click;
            // 
            // cancxToolStripMenuItem
            // 
            cancxToolStripMenuItem.Image = Properties.Resources.Delete_32;
            cancxToolStripMenuItem.Name = "cancxToolStripMenuItem";
            cancxToolStripMenuItem.Size = new Size(249, 26);
            cancxToolStripMenuItem.Text = "Cancel Application";
            cancxToolStripMenuItem.Click += CancelToolStripMenuItem_Click;
            // 
            // frmManageLocalDrivingLicenseApplications
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 787);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(cbStatus);
            Controls.Add(tbSearchBy);
            Controls.Add(labCountOfRecords);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(pbAddNew);
            Controls.Add(labGF);
            Controls.Add(cbFilter);
            Controls.Add(DgvLocal);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmManageLocalDrivingLicenseApplications";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Manage Local Driving License Applications";
            Load += frmManageLocalDrivingLicenseApplications_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvLocal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAddNew).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView DgvLocal;
        private ComboBox cbFilter;
        private Label labGF;
        private PictureBox pbAddNew;
        private Button btnClose;
        private Label label2;
        private Label labCountOfRecords;
        private TextBox tbSearchBy;
        private ComboBox cbStatus;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private ToolStripMenuItem editApplicationToolStripMenuItem;
        private ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private ToolStripMenuItem cancxToolStripMenuItem;
    }
}