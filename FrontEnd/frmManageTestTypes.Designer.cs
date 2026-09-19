namespace FrontEnd
{
    partial class frmManageTestTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageTestTypes));
            labCountOfRecords = new Label();
            label2 = new Label();
            dgvTestTypes = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editAppToolStripMenuItem = new ToolStripMenuItem();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTestTypes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labCountOfRecords
            // 
            labCountOfRecords.AutoSize = true;
            labCountOfRecords.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labCountOfRecords.Location = new Point(220, 566);
            labCountOfRecords.Name = "labCountOfRecords";
            labCountOfRecords.Size = new Size(33, 38);
            labCountOfRecords.TabIndex = 10;
            labCountOfRecords.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 562);
            label2.Name = "label2";
            label2.Size = new Size(188, 46);
            label2.TabIndex = 9;
            label2.Text = "# Records :";
            // 
            // dgvTestTypes
            // 
            dgvTestTypes.AllowUserToAddRows = false;
            dgvTestTypes.AllowUserToDeleteRows = false;
            dgvTestTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTestTypes.BackgroundColor = Color.WhiteSmoke;
            dgvTestTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTestTypes.Location = new Point(3, 276);
            dgvTestTypes.Name = "dgvTestTypes";
            dgvTestTypes.ReadOnly = true;
            dgvTestTypes.RowHeadersWidth = 51;
            dgvTestTypes.Size = new Size(741, 272);
            dgvTestTypes.TabIndex = 8;
            dgvTestTypes.SelectionChanged += dgvTestTypes_SelectionChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.TestType_512;
            pictureBox1.Location = new Point(267, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(231, 212);
            label1.Name = "label1";
            label1.Size = new Size(285, 41);
            label1.TabIndex = 6;
            label1.Text = "Manage Test Types";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editAppToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(139, 30);
            // 
            // editAppToolStripMenuItem
            // 
            editAppToolStripMenuItem.Image = Properties.Resources.edit_321;
            editAppToolStripMenuItem.Name = "editAppToolStripMenuItem";
            editAppToolStripMenuItem.Size = new Size(138, 26);
            editAppToolStripMenuItem.Text = "Edit Test";
            editAppToolStripMenuItem.Click += editAppToolStripMenuItem_Click;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.BottomLeft;
            btnClose.Location = new Point(599, 566);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(137, 44);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmManageTestTypes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 622);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(labCountOfRecords);
            Controls.Add(label2);
            Controls.Add(dgvTestTypes);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmManageTestTypes";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Test Types";
            ((System.ComponentModel.ISupportInitialize)dgvTestTypes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labCountOfRecords;
        private Label label2;
        private DataGridView dgvTestTypes;
        private PictureBox pictureBox1;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editAppToolStripMenuItem;
        private Button btnClose;
    }
}