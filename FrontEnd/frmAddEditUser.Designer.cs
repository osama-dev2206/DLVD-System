namespace FrontEnd
{
    partial class frmAddEditUser
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
            tabControl = new TabControl();
            tabPersonInfo = new TabPage();
            ctrlFilterFindBy = new ctrlFilterFindBy();
            ctrlPersonInfo1 = new ctrlPersonInfo();
            btnNext = new Button();
            tbLoginInfo = new TabPage();
            cbIsActive = new CheckBox();
            tbPasswordConfrimation = new TextBox();
            tbPassword = new TextBox();
            tbUserName = new TextBox();
            labPersonID = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            labFormMode = new Label();
            btnSave = new Button();
            btnClose = new Button();
            errorProvider1 = new ErrorProvider(components);
            tabControl.SuspendLayout();
            tabPersonInfo.SuspendLayout();
            tbLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPersonInfo);
            tabControl.Controls.Add(tbLoginInfo);
            tabControl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl.Location = new Point(12, 76);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(985, 516);
            tabControl.TabIndex = 0;
            tabControl.Selecting += tabControl_Selecting;
            // 
            // tabPersonInfo
            // 
            tabPersonInfo.BackColor = Color.White;
            tabPersonInfo.Controls.Add(ctrlFilterFindBy);
            tabPersonInfo.Controls.Add(ctrlPersonInfo1);
            tabPersonInfo.Controls.Add(btnNext);
            tabPersonInfo.Location = new Point(4, 29);
            tabPersonInfo.Name = "tabPersonInfo";
            tabPersonInfo.Padding = new Padding(3);
            tabPersonInfo.Size = new Size(977, 483);
            tabPersonInfo.TabIndex = 0;
            tabPersonInfo.Text = "Person Info";
            // 
            // ctrlFilterFindBy
            // 
            ctrlFilterFindBy.Location = new Point(16, 16);
            ctrlFilterFindBy.Name = "ctrlFilterFindBy";
            ctrlFilterFindBy.Size = new Size(953, 112);
            ctrlFilterFindBy.TabIndex = 4;
            // 
            // ctrlPersonInfo1
            // 
            ctrlPersonInfo1.BackColor = Color.White;
            ctrlPersonInfo1.Location = new Point(0, 121);
            ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            ctrlPersonInfo1.Size = new Size(981, 304);
            ctrlPersonInfo1.TabIndex = 0;
            // 
            // btnNext
            // 
            btnNext.FlatAppearance.BorderColor = Color.Black;
            btnNext.FlatAppearance.BorderSize = 3;
            btnNext.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnNext.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.Black;
            btnNext.Image = Properties.Resources.Next_32;
            btnNext.ImageAlign = ContentAlignment.MiddleRight;
            btnNext.Location = new Point(793, 431);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(176, 46);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // tbLoginInfo
            // 
            tbLoginInfo.BackColor = Color.FromArgb(224, 224, 224);
            tbLoginInfo.Controls.Add(cbIsActive);
            tbLoginInfo.Controls.Add(tbPasswordConfrimation);
            tbLoginInfo.Controls.Add(tbPassword);
            tbLoginInfo.Controls.Add(tbUserName);
            tbLoginInfo.Controls.Add(labPersonID);
            tbLoginInfo.Controls.Add(pictureBox4);
            tbLoginInfo.Controls.Add(pictureBox3);
            tbLoginInfo.Controls.Add(pictureBox2);
            tbLoginInfo.Controls.Add(pictureBox1);
            tbLoginInfo.Controls.Add(label5);
            tbLoginInfo.Controls.Add(label4);
            tbLoginInfo.Controls.Add(label3);
            tbLoginInfo.Controls.Add(label2);
            tbLoginInfo.Location = new Point(4, 29);
            tbLoginInfo.Name = "tbLoginInfo";
            tbLoginInfo.Padding = new Padding(3);
            tbLoginInfo.Size = new Size(1017, 483);
            tbLoginInfo.TabIndex = 1;
            tbLoginInfo.Text = "LoginInfo";
            // 
            // cbIsActive
            // 
            cbIsActive.AutoSize = true;
            cbIsActive.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            cbIsActive.Location = new Point(287, 327);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(125, 32);
            cbIsActive.TabIndex = 4;
            cbIsActive.Text = "Is Active ?";
            cbIsActive.UseVisualStyleBackColor = true;
            cbIsActive.CheckedChanged += cbIsActive_CheckedChanged;
            // 
            // tbPasswordConfrimation
            // 
            tbPasswordConfrimation.Location = new Point(287, 273);
            tbPasswordConfrimation.MaxLength = 20;
            tbPasswordConfrimation.Name = "tbPasswordConfrimation";
            tbPasswordConfrimation.PasswordChar = '*';
            tbPasswordConfrimation.Size = new Size(181, 27);
            tbPasswordConfrimation.TabIndex = 3;
            tbPasswordConfrimation.Validating += tbPasswordConfrimation_Validating;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(287, 214);
            tbPassword.MaxLength = 20;
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(181, 27);
            tbPassword.TabIndex = 2;
            tbPassword.Validating += tbPassword_Validating;
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(287, 162);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(181, 27);
            tbUserName.TabIndex = 1;
            tbUserName.Validating += tbUserName_Validating;
            // 
            // labPersonID
            // 
            labPersonID.AutoSize = true;
            labPersonID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labPersonID.Location = new Point(257, 100);
            labPersonID.Name = "labPersonID";
            labPersonID.Size = new Size(30, 28);
            labPersonID.TabIndex = 8;
            labPersonID.Text = "??";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Password_32;
            pictureBox4.Location = new Point(176, 204);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(63, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Password_32;
            pictureBox3.Location = new Point(208, 260);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(63, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Person_321;
            pictureBox2.Location = new Point(176, 158);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Number_321;
            pictureBox1.Location = new Point(156, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(20, 266);
            label5.Name = "label5";
            label5.Size = new Size(193, 28);
            label5.TabIndex = 3;
            label5.Text = "Confrim Password : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(62, 210);
            label4.Name = "label4";
            label4.Size = new Size(108, 28);
            label4.TabIndex = 2;
            label4.Text = "Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(57, 161);
            label3.Name = "label3";
            label3.Size = new Size(118, 28);
            label3.TabIndex = 1;
            label3.Text = "UserName :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(71, 100);
            label2.Name = "label2";
            label2.Size = new Size(90, 28);
            label2.TabIndex = 0;
            label2.Text = "UserID : ";
            // 
            // labFormMode
            // 
            labFormMode.Dock = DockStyle.Top;
            labFormMode.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labFormMode.ForeColor = Color.Red;
            labFormMode.Location = new Point(0, 0);
            labFormMode.Name = "labFormMode";
            labFormMode.Size = new Size(997, 62);
            labFormMode.TabIndex = 1;
            labFormMode.Text = "Add New User";
            labFormMode.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(799, 612);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(176, 52);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnClose.Image = Properties.Resources.Close_321;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(589, 612);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(176, 52);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddEditUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(997, 688);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(labFormMode);
            Controls.Add(tabControl);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddEditUser";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmAddEditUser";
            tabControl.ResumeLayout(false);
            tabPersonInfo.ResumeLayout(false);
            tbLoginInfo.ResumeLayout(false);
            tbLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPersonInfo;
        private TabPage tbLoginInfo;
        private Label labFormMode;
        private ctrlPersonInfo ctrlPersonInfo1;
        private Button btnNext;
        private Button btnSave;
        private Button btnClose;
        private ctrlFilterFindBy ctrlFilterFindBy; // it is used 
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private Label labPersonID;
        private TextBox tbUserName;
        private TextBox tbPassword;
        private TextBox tbPasswordConfrimation;
        private CheckBox cbIsActive;
        private ErrorProvider errorProvider1;
    }
}