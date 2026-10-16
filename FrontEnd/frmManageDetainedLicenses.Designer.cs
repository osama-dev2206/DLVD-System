namespace FrontEnd
{
    partial class frmManageDetainedLicenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageDetainedLicenses));
            showLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            showLicenseToolStripMenuItem = new ToolStripMenuItem();
            showPersonDetailsToolStripMenuItem = new ToolStripMenuItem();
            tbSearchBy = new TextBox();
            labCountOfRecords = new Label();
            label2 = new Label();
            btnClose = new Button();
            pbDetainLic = new PictureBox();
            labGF = new Label();
            cbFilter = new ComboBox();
            DgvLicenses = new DataGridView();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pictureBox1 = new PictureBox();
            pbReleaseLic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbDetainLic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvLicenses).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbReleaseLic).BeginInit();
            SuspendLayout();
            // 
            // showLicenseHistoryToolStripMenuItem
            // 
            showLicenseHistoryToolStripMenuItem.Image = Properties.Resources.PersonLicenseHistory_32;
            showLicenseHistoryToolStripMenuItem.Name = "showLicenseHistoryToolStripMenuItem";
            showLicenseHistoryToolStripMenuItem.Size = new Size(221, 26);
            showLicenseHistoryToolStripMenuItem.Text = "Show License History";
            showLicenseHistoryToolStripMenuItem.Click += showLicenseHistoryToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(218, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            showLicenseToolStripMenuItem.Image = Properties.Resources.License_View_32;
            showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            showLicenseToolStripMenuItem.Size = new Size(221, 26);
            showLicenseToolStripMenuItem.Text = "Show License";
            showLicenseToolStripMenuItem.Click += showLicenseToolStripMenuItem_Click;
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            showPersonDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            showPersonDetailsToolStripMenuItem.Size = new Size(221, 26);
            showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            showPersonDetailsToolStripMenuItem.Click += showPersonDetailsToolStripMenuItem_Click;
            // 
            // tbSearchBy
            // 
            tbSearchBy.Location = new Point(339, 369);
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
            labCountOfRecords.Location = new Point(197, 747);
            labCountOfRecords.Name = "labCountOfRecords";
            labCountOfRecords.Size = new Size(27, 31);
            labCountOfRecords.TabIndex = 19;
            labCountOfRecords.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 740);
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
            btnClose.Location = new Point(1065, 729);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(204, 49);
            btnClose.TabIndex = 17;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pbDetainLic
            // 
            pbDetainLic.Image = Properties.Resources.Detain_641;
            pbDetainLic.Location = new Point(1164, 341);
            pbDetainLic.Name = "pbDetainLic";
            pbDetainLic.Size = new Size(90, 72);
            pbDetainLic.SizeMode = PictureBoxSizeMode.Zoom;
            pbDetainLic.TabIndex = 16;
            pbDetainLic.TabStop = false;
            // 
            // labGF
            // 
            labGF.AutoSize = true;
            labGF.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labGF.Location = new Point(12, 362);
            labGF.Name = "labGF";
            labGF.Size = new Size(111, 31);
            labGF.TabIndex = 15;
            labGF.Text = "Filter By :";
            // 
            // cbFilter
            // 
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "None", "DetainID", "IsReleased", "NationalNo", "FullName", "ReleaseAppID" });
            cbFilter.Location = new Point(141, 368);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(168, 28);
            cbFilter.TabIndex = 14;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // DgvLicenses
            // 
            DgvLicenses.AllowUserToAddRows = false;
            DgvLicenses.AllowUserToDeleteRows = false;
            DgvLicenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvLicenses.BackgroundColor = Color.FromArgb(224, 224, 224);
            DgvLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvLicenses.Location = new Point(12, 419);
            DgvLicenses.Name = "DgvLicenses";
            DgvLicenses.ReadOnly = true;
            DgvLicenses.RowHeadersWidth = 51;
            DgvLicenses.Size = new Size(1257, 302);
            DgvLicenses.TabIndex = 13;
            DgvLicenses.SelectionChanged += DGVLicSelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(404, 254);
            label1.Name = "label1";
            label1.Size = new Size(441, 46);
            label1.TabIndex = 12;
            label1.Text = "Manage Detained Licenses";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showPersonDetailsToolStripMenuItem, toolStripSeparator2, showLicenseToolStripMenuItem, showLicenseHistoryToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(222, 88);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Detain_5121;
            pictureBox1.Location = new Point(512, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 245);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pbReleaseLic
            // 
            pbReleaseLic.Image = Properties.Resources.Release_Detained_License_64;
            pbReleaseLic.Location = new Point(1041, 341);
            pbReleaseLic.Name = "pbReleaseLic";
            pbReleaseLic.Size = new Size(90, 72);
            pbReleaseLic.SizeMode = PictureBoxSizeMode.Zoom;
            pbReleaseLic.TabIndex = 21;
            pbReleaseLic.TabStop = false;
            // 
            // frmManageDetainedLicenses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 787);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(pbReleaseLic);
            Controls.Add(tbSearchBy);
            Controls.Add(labCountOfRecords);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(pbDetainLic);
            Controls.Add(labGF);
            Controls.Add(cbFilter);
            Controls.Add(DgvLicenses);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmManageDetainedLicenses";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Manage Detained Licenses";
            Load += frmManageDetainedLicenses_Load;
            ((System.ComponentModel.ISupportInitialize)pbDetainLic).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvLicenses).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbReleaseLic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem showLicenseHistoryToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem showLicenseToolStripMenuItem;
        private ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private TextBox tbSearchBy;
        private Label labCountOfRecords;
        private Label label2;
        private Button btnClose;
        private PictureBox pbDetainLic;
        private Label labGF;
        private ComboBox cbFilter;
        private DataGridView DgvLicenses;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private PictureBox pictureBox1;
        private PictureBox pbReleaseLic;
    }
}