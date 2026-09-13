namespace FrontEnd
{
    partial class FrmPeopleManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPeopleManagement));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            DGVPeople = new DataGridView();
            label2 = new Label();
            tbSearchBy = new TextBox();
            cbFilter = new ComboBox();
            btnClose = new Button();
            pbAdd = new PictureBox();
            label3 = new Label();
            labCountOfRecords = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            addToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            showDetailsToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVPeople).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAdd).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(504, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1305, 56);
            label1.TabIndex = 1;
            label1.Text = "People Management";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // DGVPeople
            // 
            DGVPeople.AllowUserToAddRows = false;
            DGVPeople.AllowUserToDeleteRows = false;
            DGVPeople.BackgroundColor = Color.FromArgb(224, 224, 224);
            DGVPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVPeople.Location = new Point(0, 406);
            DGVPeople.Name = "DGVPeople";
            DGVPeople.ReadOnly = true;
            DGVPeople.RowHeadersWidth = 51;
            DGVPeople.Size = new Size(1305, 276);
            DGVPeople.TabIndex = 0;
            DGVPeople.SelectionChanged += DGVPeople_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 350);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 4;
            label2.Text = "Filter By";
            // 
            // tbSearchBy
            // 
            tbSearchBy.Cursor = Cursors.IBeam;
            tbSearchBy.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbSearchBy.Location = new Point(360, 351);
            tbSearchBy.Name = "tbSearchBy";
            tbSearchBy.PlaceholderText = "Search According To Filter";
            tbSearchBy.Size = new Size(348, 27);
            tbSearchBy.TabIndex = 2;
            tbSearchBy.TextAlign = HorizontalAlignment.Center;
            tbSearchBy.TextChanged += tbSearchBy_TextChanged;
            // 
            // cbFilter
            // 
            cbFilter.BackColor = Color.FromArgb(224, 224, 224);
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "None", "PersonID", "NationalNo", "FirstName", "LastName", "SecondName", "ThirdName", "LastName", "Nationality", "Gender", "Phone", "Email" });
            cbFilter.Location = new Point(97, 347);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(230, 36);
            cbFilter.TabIndex = 1;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.BackgroundImage = Properties.Resources.Close_321;
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.FlatAppearance.MouseDownBackColor = Color.Red;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(1124, 694);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(169, 53);
            btnClose.TabIndex = 5;
            btnClose.Text = "   Close";
            btnClose.TextAlign = ContentAlignment.MiddleLeft;
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pbAdd
            // 
            pbAdd.BackgroundImage = Properties.Resources.Add_Person_72;
            pbAdd.BackgroundImageLayout = ImageLayout.Stretch;
            pbAdd.Location = new Point(1199, 316);
            pbAdd.Name = "pbAdd";
            pbAdd.Size = new Size(79, 84);
            pbAdd.TabIndex = 6;
            pbAdd.TabStop = false;
            pbAdd.Click += Add_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 706);
            label3.Name = "label3";
            label3.Size = new Size(130, 31);
            label3.TabIndex = 7;
            label3.Text = "# Records :";
            // 
            // labCountOfRecords
            // 
            labCountOfRecords.AutoSize = true;
            labCountOfRecords.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labCountOfRecords.Location = new Point(148, 707);
            labCountOfRecords.Name = "labCountOfRecords";
            labCountOfRecords.Size = new Size(23, 28);
            labCountOfRecords.TabIndex = 8;
            labCountOfRecords.Text = "0";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, toolStripSeparator3, showDetailsToolStripMenuItem1, toolStripSeparator1, showDetailsToolStripMenuItem, toolStripSeparator4, deleteToolStripMenuItem, toolStripSeparator2 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(169, 132);
            contextMenuStrip1.ItemClicked += contextMenuStrip1_ItemClicked;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Image = Properties.Resources.Add_Person_40;
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(168, 26);
            addToolStripMenuItem.Text = "Add";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(165, 6);
            // 
            // showDetailsToolStripMenuItem1
            // 
            showDetailsToolStripMenuItem1.Image = Properties.Resources.PersonDetails_32;
            showDetailsToolStripMenuItem1.Name = "showDetailsToolStripMenuItem1";
            showDetailsToolStripMenuItem1.Size = new Size(168, 26);
            showDetailsToolStripMenuItem1.Text = "Show Details";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(165, 6);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Image = Properties.Resources.edit_32;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(168, 26);
            showDetailsToolStripMenuItem.Text = "Edit";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(165, 6);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = Properties.Resources.Delete_32_2;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(168, 26);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(165, 6);
            // 
            // FrmPeopleManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1305, 753);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(labCountOfRecords);
            Controls.Add(label3);
            Controls.Add(pbAdd);
            Controls.Add(btnClose);
            Controls.Add(tbSearchBy);
            Controls.Add(label2);
            Controls.Add(cbFilter);
            Controls.Add(DGVPeople);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPeopleManagement";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "People Management";
            Load += FrmPeopleManagement_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVPeople).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAdd).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView DGVPeople;
        private Label label2;
        private TextBox tbSearchBy;
        private ComboBox cbFilter;
        private Button btnClose;
        private PictureBox pbAdd;
        private Label label3;
        private Label labCountOfRecords;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showDetailsToolStripMenuItem1;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator3;
    }
}