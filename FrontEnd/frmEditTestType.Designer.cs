namespace FrontEnd
{
    partial class frmEditTestType
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            tbTitle = new TextBox();
            tbDescription = new RichTextBox();
            tbFees = new TextBox();
            labTestTypeId = new Label();
            btnSave = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 62);
            label1.TabIndex = 0;
            label1.Text = "Update Test Type";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 94);
            label2.Name = "label2";
            label2.Size = new Size(64, 41);
            label2.TabIndex = 1;
            label2.Text = "ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 217);
            label3.Name = "label3";
            label3.Size = new Size(190, 41);
            label3.TabIndex = 2;
            label3.Text = "Description :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 327);
            label4.Name = "label4";
            label4.Size = new Size(93, 41);
            label4.TabIndex = 3;
            label4.Text = "Fees :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(28, 156);
            label5.Name = "label5";
            label5.Size = new Size(93, 41);
            label5.TabIndex = 4;
            label5.Text = "Title :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ApplicationTitle;
            pictureBox1.Location = new Point(127, 155);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.money_32;
            pictureBox2.Location = new Point(127, 327);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.ApplicationTitle1;
            pictureBox3.Location = new Point(224, 216);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(185, 163);
            tbTitle.MaxLength = 100;
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(202, 27);
            tbTitle.TabIndex = 8;
            tbTitle.TextChanged += tbTitle_TextChanged;
            tbTitle.KeyPress += tbTitleAndDescription_KeyPress;
            // 
            // tbDescription
            // 
            tbDescription.BackColor = Color.White;
            tbDescription.BorderStyle = BorderStyle.None;
            tbDescription.Location = new Point(283, 216);
            tbDescription.MaxLength = 50;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(359, 84);
            tbDescription.TabIndex = 9;
            tbDescription.Text = "";
            tbDescription.TextChanged += tbDescription_TextChanged;
            tbDescription.KeyPress += tbTitleAndDescription_KeyPress;
            // 
            // tbFees
            // 
            tbFees.Location = new Point(197, 335);
            tbFees.Name = "tbFees";
            tbFees.Size = new Size(205, 27);
            tbFees.TabIndex = 10;
            tbFees.TextChanged += tbFees_TextChanged;
            tbFees.KeyPress += tbFees_KeyPress;
            // 
            // labTestTypeId
            // 
            labTestTypeId.AutoSize = true;
            labTestTypeId.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labTestTypeId.Location = new Point(98, 95);
            labTestTypeId.Name = "labTestTypeId";
            labTestTypeId.Size = new Size(33, 38);
            labTestTypeId.TabIndex = 11;
            labTestTypeId.Text = "0";
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.BottomLeft;
            btnSave.Location = new Point(639, 386);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(146, 47);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatAppearance.MouseOverBackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(460, 386);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(146, 47);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmEditTestType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 445);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(labTestTypeId);
            Controls.Add(tbFees);
            Controls.Add(tbDescription);
            Controls.Add(tbTitle);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmEditTestType";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Test Type";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox tbTitle;
        private RichTextBox tbDescription;
        private TextBox tbFees;
        private Label labTestTypeId;
        private Button btnSave;
        private Button btnClose;
    }
}