namespace FrontEnd
{
    partial class frmApplicationTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApplicationTypes));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dgvApplicationTypes = new DataGridView();
            label2 = new Label();
            labCountOfRecords = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editAppToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvApplicationTypes).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(162, 285);
            label1.Name = "label1";
            label1.Size = new Size(393, 41);
            label1.TabIndex = 0;
            label1.Text = "Manage Application Types";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Application_Types_512;
            pictureBox1.Location = new Point(252, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 232);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dgvApplicationTypes
            // 
            dgvApplicationTypes.AllowUserToAddRows = false;
            dgvApplicationTypes.AllowUserToDeleteRows = false;
            dgvApplicationTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvApplicationTypes.BackgroundColor = Color.WhiteSmoke;
            dgvApplicationTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApplicationTypes.Location = new Point(8, 355);
            dgvApplicationTypes.Name = "dgvApplicationTypes";
            dgvApplicationTypes.ReadOnly = true;
            dgvApplicationTypes.RowHeadersWidth = 51;
            dgvApplicationTypes.Size = new Size(714, 272);
            dgvApplicationTypes.TabIndex = 2;
            dgvApplicationTypes.SelectionChanged += dgvApplicationTypes_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 642);
            label2.Name = "label2";
            label2.Size = new Size(188, 46);
            label2.TabIndex = 3;
            label2.Text = "# Records :";
            // 
            // labCountOfRecords
            // 
            labCountOfRecords.AutoSize = true;
            labCountOfRecords.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labCountOfRecords.Location = new Point(207, 646);
            labCountOfRecords.Name = "labCountOfRecords";
            labCountOfRecords.Size = new Size(33, 38);
            labCountOfRecords.TabIndex = 4;
            labCountOfRecords.Text = "0";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editAppToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(190, 30);
            // 
            // editAppToolStripMenuItem
            // 
            editAppToolStripMenuItem.Image = Properties.Resources.edit_321;
            editAppToolStripMenuItem.Name = "editAppToolStripMenuItem";
            editAppToolStripMenuItem.Size = new Size(189, 26);
            editAppToolStripMenuItem.Text = "Edit Application";
            editAppToolStripMenuItem.Click += editAppToolStripMenuItem_Click;
            // 
            // frmApplicationTypes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 697);
            Controls.Add(labCountOfRecords);
            Controls.Add(label2);
            Controls.Add(dgvApplicationTypes);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmApplicationTypes";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Manage Application Types";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvApplicationTypes).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dgvApplicationTypes;
        private Label label2;
        private Label labCountOfRecords;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editAppToolStripMenuItem;
    }
}