namespace FrontEnd
{
    partial class frmListDrivers
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
            pictureBox1 = new PictureBox();
            DGVDrivers = new DataGridView();
            labCountOfRecords = new Label();
            label3 = new Label();
            btnClose = new Button();
            tbSearchBy = new TextBox();
            label2 = new Label();
            cbFilter = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVDrivers).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Driver_Main;
            pictureBox1.Location = new Point(493, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(328, 240);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // DGVDrivers
            // 
            DGVDrivers.AllowUserToAddRows = false;
            DGVDrivers.AllowUserToDeleteRows = false;
            DGVDrivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVDrivers.BackgroundColor = Color.FromArgb(224, 224, 224);
            DGVDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVDrivers.GridColor = Color.FromArgb(224, 224, 224);
            DGVDrivers.Location = new Point(12, 340);
            DGVDrivers.Name = "DGVDrivers";
            DGVDrivers.ReadOnly = true;
            DGVDrivers.RowHeadersWidth = 51;
            DGVDrivers.Size = new Size(1289, 264);
            DGVDrivers.TabIndex = 27;
            // 
            // labCountOfRecords
            // 
            labCountOfRecords.AutoSize = true;
            labCountOfRecords.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labCountOfRecords.Location = new Point(145, 638);
            labCountOfRecords.Name = "labCountOfRecords";
            labCountOfRecords.Size = new Size(23, 28);
            labCountOfRecords.TabIndex = 26;
            labCountOfRecords.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 637);
            label3.Name = "label3";
            label3.Size = new Size(130, 31);
            label3.TabIndex = 25;
            label3.Text = "# Records :";
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
            btnClose.Location = new Point(1143, 623);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(161, 53);
            btnClose.TabIndex = 24;
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
            tbSearchBy.Location = new Point(358, 293);
            tbSearchBy.Name = "tbSearchBy";
            tbSearchBy.PlaceholderText = "Search According To Filter";
            tbSearchBy.Size = new Size(348, 27);
            tbSearchBy.TabIndex = 22;
            tbSearchBy.TextAlign = HorizontalAlignment.Center;
            tbSearchBy.TextChanged += tbSearchBy_TextChanged;
            tbSearchBy.KeyPress += tbSearchBy_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 292);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 23;
            label2.Text = "Filter By";
            // 
            // cbFilter
            // 
            cbFilter.BackColor = Color.FromArgb(224, 224, 224);
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "None", "Driver ID", "Person ID", "National No", "Full Name" });
            cbFilter.Location = new Point(97, 288);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(230, 36);
            cbFilter.TabIndex = 21;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // frmListDrivers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1316, 676);
            Controls.Add(DGVDrivers);
            Controls.Add(labCountOfRecords);
            Controls.Add(label3);
            Controls.Add(btnClose);
            Controls.Add(tbSearchBy);
            Controls.Add(label2);
            Controls.Add(cbFilter);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListDrivers";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "List Drivers";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVDrivers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView DGVDrivers;
        private Label labCountOfRecords;
        private Label label3;
        private Button btnClose;
        private TextBox tbSearchBy;
        private Label label2;
        private ComboBox cbFilter;
    }
}