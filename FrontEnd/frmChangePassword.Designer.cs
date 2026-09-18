namespace FrontEnd
{
    partial class frmChangePassword
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
            ctrlPersonInfo1 = new ctrlPersonInfo();
            ctrlShowUserInfo1 = new ctrlShowUserInfo();
            groupBox1 = new GroupBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbConfrimPassword = new TextBox();
            tbNewPassword = new TextBox();
            tbCurrentPassword = new TextBox();
            btnSave = new Button();
            btnClose = new Button();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ctrlPersonInfo1
            // 
            ctrlPersonInfo1.Location = new Point(14, 30);
            ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            ctrlPersonInfo1.Size = new Size(912, 301);
            ctrlPersonInfo1.TabIndex = 0;
            // 
            // ctrlShowUserInfo1
            // 
            ctrlShowUserInfo1.Location = new Point(14, 337);
            ctrlShowUserInfo1.Name = "ctrlShowUserInfo1";
            ctrlShowUserInfo1.Size = new Size(862, 115);
            ctrlShowUserInfo1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbConfrimPassword);
            groupBox1.Controls.Add(tbNewPassword);
            groupBox1.Controls.Add(tbCurrentPassword);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(14, 458);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(874, 163);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Password_32;
            pictureBox3.Location = new Point(186, 125);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Password_32;
            pictureBox2.Location = new Point(186, 79);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Password_32;
            pictureBox1.Location = new Point(186, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 128);
            label3.Name = "label3";
            label3.Size = new Size(166, 23);
            label3.TabIndex = 5;
            label3.Text = "Confrim Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 82);
            label2.Name = "label2";
            label2.Size = new Size(136, 23);
            label2.TabIndex = 4;
            label2.Text = "New Password :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 36);
            label1.Name = "label1";
            label1.Size = new Size(161, 23);
            label1.TabIndex = 3;
            label1.Text = "Current Password :";
            // 
            // tbConfrimPassword
            // 
            tbConfrimPassword.Location = new Point(245, 126);
            tbConfrimPassword.MaxLength = 20;
            tbConfrimPassword.Name = "tbConfrimPassword";
            tbConfrimPassword.PasswordChar = '*';
            tbConfrimPassword.Size = new Size(184, 27);
            tbConfrimPassword.TabIndex = 2;
            tbConfrimPassword.Validating += tbConfrimPassword_Validating;
            // 
            // tbNewPassword
            // 
            tbNewPassword.Location = new Point(245, 80);
            tbNewPassword.MaxLength = 20;
            tbNewPassword.Name = "tbNewPassword";
            tbNewPassword.PasswordChar = '*';
            tbNewPassword.Size = new Size(184, 27);
            tbNewPassword.TabIndex = 1;
            tbNewPassword.Validating += tbNewPassword_Validating;
            // 
            // tbCurrentPassword
            // 
            tbCurrentPassword.Location = new Point(245, 34);
            tbCurrentPassword.MaxLength = 20;
            tbCurrentPassword.Name = "tbCurrentPassword";
            tbCurrentPassword.PasswordChar = '*';
            tbCurrentPassword.Size = new Size(184, 27);
            tbCurrentPassword.TabIndex = 0;
            tbCurrentPassword.Validating += tbCurrentPassword_Validating;
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.BorderSize = 2;
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.BottomLeft;
            btnSave.Location = new Point(579, 647);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(149, 44);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 2;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_322;
            btnClose.ImageAlign = ContentAlignment.BottomLeft;
            btnClose.Location = new Point(764, 647);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(149, 44);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmChangePassword
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(936, 706);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Controls.Add(ctrlShowUserInfo1);
            Controls.Add(ctrlPersonInfo1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmChangePassword";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Change Password";
            FormClosing += frmChangePassword_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ctrlPersonInfo ctrlPersonInfo1;
        private ctrlShowUserInfo ctrlShowUserInfo1;
        private GroupBox groupBox1;
        private Button btnSave;
        private Button btnClose;
        private TextBox tbConfrimPassword;
        private TextBox tbNewPassword;
        private TextBox tbCurrentPassword;
        private Label label1;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ErrorProvider errorProvider1;
    }
}