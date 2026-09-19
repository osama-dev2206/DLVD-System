namespace FrontEnd
{
    partial class frmManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageUsers));
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripSeparator4 = new ToolStripSeparator();
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            showDetailsToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            addToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            labCountOfRecords = new Label();
            label3 = new Label();
            pbAdd = new PictureBox();
            btnClose = new Button();
            tbSearchBy = new TextBox();
            label2 = new Label();
            cbFilter = new ComboBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            cbISActiveFilter = new ComboBox();
            DGVUsers = new DataGridView();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVUsers).BeginInit();
            SuspendLayout();
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(194, 6);
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(194, 6);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Image = Properties.Resources.edit_32;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(197, 26);
            showDetailsToolStripMenuItem.Text = "Edit";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(194, 6);
            // 
            // showDetailsToolStripMenuItem1
            // 
            showDetailsToolStripMenuItem1.Image = Properties.Resources.PersonDetails_32;
            showDetailsToolStripMenuItem1.Name = "showDetailsToolStripMenuItem1";
            showDetailsToolStripMenuItem1.Size = new Size(197, 26);
            showDetailsToolStripMenuItem1.Text = "Show Details";
            showDetailsToolStripMenuItem1.Click += showDetailsToolStripMenuItem1_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(194, 6);
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Image = Properties.Resources.Add_Person_40;
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(197, 26);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, toolStripSeparator3, showDetailsToolStripMenuItem1, toolStripSeparator1, showDetailsToolStripMenuItem, toolStripSeparator4, deleteToolStripMenuItem, toolStripSeparator2, changePasswordToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(198, 158);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = Properties.Resources.Delete_32_2;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(197, 26);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Image = Properties.Resources.Password_32;
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(197, 26);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // labCountOfRecords
            // 
            labCountOfRecords.AutoSize = true;
            labCountOfRecords.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labCountOfRecords.Location = new Point(148, 727);
            labCountOfRecords.Name = "labCountOfRecords";
            labCountOfRecords.Size = new Size(23, 28);
            labCountOfRecords.TabIndex = 18;
            labCountOfRecords.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 726);
            label3.Name = "label3";
            label3.Size = new Size(130, 31);
            label3.TabIndex = 17;
            label3.Text = "# Records :";
            // 
            // pbAdd
            // 
            pbAdd.BackgroundImageLayout = ImageLayout.Zoom;
            pbAdd.Image = Properties.Resources.Add_New_User_72;
            pbAdd.Location = new Point(1199, 336);
            pbAdd.Name = "pbAdd";
            pbAdd.Size = new Size(79, 84);
            pbAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAdd.TabIndex = 16;
            pbAdd.TabStop = false;
            pbAdd.Click += pbAdd_Click;
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.FlatAppearance.MouseDownBackColor = Color.Red;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(1124, 714);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(169, 53);
            btnClose.TabIndex = 15;
            btnClose.Text = "   Close";
            btnClose.TextAlign = ContentAlignment.MiddleLeft;
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // tbSearchBy
            // 
            tbSearchBy.Cursor = Cursors.IBeam;
            tbSearchBy.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbSearchBy.Location = new Point(558, 372);
            tbSearchBy.Name = "tbSearchBy";
            tbSearchBy.PlaceholderText = "Search According To Filter";
            tbSearchBy.Size = new Size(348, 27);
            tbSearchBy.TabIndex = 13;
            tbSearchBy.TextAlign = HorizontalAlignment.Center;
            tbSearchBy.TextChanged += tbSearchBy_TextChanged;
            tbSearchBy.KeyPress += tbSearchBy_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 370);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 14;
            label2.Text = "Filter By";
            // 
            // cbFilter
            // 
            cbFilter.BackColor = Color.FromArgb(224, 224, 224);
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "None", "UserID", "Username", "PersonID", "FullName", "IsActive" });
            cbFilter.Location = new Point(97, 367);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(230, 36);
            cbFilter.TabIndex = 11;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1319, 56);
            label1.TabIndex = 12;
            label1.Text = "Users Management";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Users_2_400;
            pictureBox1.Location = new Point(504, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // cbISActiveFilter
            // 
            cbISActiveFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbISActiveFilter.FormattingEnabled = true;
            cbISActiveFilter.Items.AddRange(new object[] { "All", "Yes", "No" });
            cbISActiveFilter.Location = new Point(360, 371);
            cbISActiveFilter.Name = "cbISActiveFilter";
            cbISActiveFilter.Size = new Size(178, 28);
            cbISActiveFilter.TabIndex = 19;
            cbISActiveFilter.Visible = false;
            cbISActiveFilter.SelectedIndexChanged += cbISActiveFilter_SelectedIndexChanged;
            // 
            // DGVUsers
            // 
            DGVUsers.AllowUserToAddRows = false;
            DGVUsers.AllowUserToDeleteRows = false;
            DGVUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVUsers.BackgroundColor = Color.FromArgb(224, 224, 224);
            DGVUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVUsers.GridColor = SystemColors.HighlightText;
            DGVUsers.Location = new Point(18, 443);
            DGVUsers.Name = "DGVUsers";
            DGVUsers.ReadOnly = true;
            DGVUsers.RowHeadersWidth = 51;
            DGVUsers.Size = new Size(1289, 264);
            DGVUsers.TabIndex = 20;
            DGVUsers.SelectionChanged += DGVUsersSelectionChanged;
            // 
            // frmManageUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1319, 782);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(DGVUsers);
            Controls.Add(cbISActiveFilter);
            Controls.Add(labCountOfRecords);
            Controls.Add(label3);
            Controls.Add(pbAdd);
            Controls.Add(btnClose);
            Controls.Add(tbSearchBy);
            Controls.Add(label2);
            Controls.Add(cbFilter);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmManageUsers";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Users";
            Load += frmManageUsers_Load;
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem showDetailsToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem addToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Label labCountOfRecords;
        private Label label3;
        private PictureBox pbAdd;
        private Button btnClose;
        private TextBox tbSearchBy;
        private Label label2;
        private ComboBox cbFilter;
        private Label label1;
        private PictureBox pictureBox1;
        private ComboBox cbISActiveFilter;
        private DataGridView DGVUsers;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}