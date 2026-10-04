namespace FrontEnd
{
    partial class frnManageInternationalLicensesApps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frnManageInternationalLicensesApps));
            showLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            showLicenseToolStripMenuItem = new ToolStripMenuItem();
            showApplicationDetailsToolStripMenuItem = new ToolStripMenuItem();
            tbSearchBy = new TextBox();
            labCountOfRecords = new Label();
            label2 = new Label();
            btnClose = new Button();
            pbAddNew = new PictureBox();
            labGF = new Label();
            cbFilter = new ComboBox();
            DgvInternational = new DataGridView();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbAddNew).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvInternational).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // showLicenseHistoryToolStripMenuItem
            // 
            showLicenseHistoryToolStripMenuItem.Image = Properties.Resources.PersonLicenseHistory_32;
            showLicenseHistoryToolStripMenuItem.Name = "showLicenseHistoryToolStripMenuItem";
            showLicenseHistoryToolStripMenuItem.Size = new Size(249, 26);
            showLicenseHistoryToolStripMenuItem.Text = "Show License History";
            showLicenseHistoryToolStripMenuItem.Click += showLicenseHistoryToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(246, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            showLicenseToolStripMenuItem.Image = Properties.Resources.License_View_32;
            showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            showLicenseToolStripMenuItem.Size = new Size(249, 26);
            showLicenseToolStripMenuItem.Text = "Show License";
            showLicenseToolStripMenuItem.Click += showLicenseToolStripMenuItem_Click;
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            showApplicationDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            showApplicationDetailsToolStripMenuItem.Size = new Size(249, 26);
            showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            showApplicationDetailsToolStripMenuItem.Click += showApplicationDetailsToolStripMenuItem_Click;
            // 
            // tbSearchBy
            // 
            tbSearchBy.Location = new Point(353, 356);
            tbSearchBy.Name = "tbSearchBy";
            tbSearchBy.Size = new Size(291, 27);
            tbSearchBy.TabIndex = 20;
            tbSearchBy.TextChanged += tbSearchBy_TextChanged;
            tbSearchBy.KeyPress += tbSearchBy_KeyPress;
            // 
            // labCountOfRecords
            // 
            labCountOfRecords.AutoSize = true;
            labCountOfRecords.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labCountOfRecords.Location = new Point(187, 744);
            labCountOfRecords.Name = "labCountOfRecords";
            labCountOfRecords.Size = new Size(27, 31);
            labCountOfRecords.TabIndex = 19;
            labCountOfRecords.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(2, 737);
            label2.Name = "label2";
            label2.Size = new Size(179, 41);
            label2.TabIndex = 18;
            label2.Text = "#  Records :";
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
            btnClose.TabIndex = 17;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pbAddNew
            // 
            pbAddNew.Image = Properties.Resources.New_Application_64;
            pbAddNew.Location = new Point(1162, 326);
            pbAddNew.Name = "pbAddNew";
            pbAddNew.Size = new Size(90, 72);
            pbAddNew.SizeMode = PictureBoxSizeMode.Zoom;
            pbAddNew.TabIndex = 16;
            pbAddNew.TabStop = false;
            pbAddNew.Click += pbAddNew_Click;
            // 
            // labGF
            // 
            labGF.AutoSize = true;
            labGF.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labGF.Location = new Point(15, 354);
            labGF.Name = "labGF";
            labGF.Size = new Size(111, 31);
            labGF.TabIndex = 15;
            labGF.Text = "Filter By :";
            // 
            // cbFilter
            // 
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "None", "ApplicationID", "DriverID", "LicenseID", "InternationalLicenseID" });
            cbFilter.Location = new Point(144, 355);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(168, 28);
            cbFilter.TabIndex = 14;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // DgvInternational
            // 
            DgvInternational.AllowUserToAddRows = false;
            DgvInternational.AllowUserToDeleteRows = false;
            DgvInternational.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvInternational.BackgroundColor = Color.FromArgb(224, 224, 224);
            DgvInternational.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvInternational.Location = new Point(12, 404);
            DgvInternational.Name = "DgvInternational";
            DgvInternational.ReadOnly = true;
            DgvInternational.RowHeadersWidth = 51;
            DgvInternational.Size = new Size(1257, 302);
            DgvInternational.TabIndex = 13;
            DgvInternational.SelectionChanged += DGVInternationalSelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(278, 235);
            label1.Name = "label1";
            label1.Size = new Size(699, 46);
            label1.TabIndex = 12;
            label1.Text = "International Driving License  Applications";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showApplicationDetailsToolStripMenuItem, toolStripSeparator2, showLicenseToolStripMenuItem, showLicenseHistoryToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(250, 88);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Application_Types_5121;
            pictureBox1.Location = new Point(526, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // frnManageInternationalLicensesApps
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 787);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(tbSearchBy);
            Controls.Add(labCountOfRecords);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(pbAddNew);
            Controls.Add(labGF);
            Controls.Add(cbFilter);
            Controls.Add(DgvInternational);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frnManageInternationalLicensesApps";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "International Licenses Applications";
            ((System.ComponentModel.ISupportInitialize)pbAddNew).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvInternational).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem showLicenseHistoryToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem showLicenseToolStripMenuItem;
        private ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private TextBox tbSearchBy;
        private Label labCountOfRecords;
        private Label label2;
        private Button btnClose;
        private PictureBox pbAddNew;
        private Label labGF;
        private ComboBox cbFilter;
        private DataGridView DgvInternational;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private PictureBox pictureBox1;
    }
}