namespace FrontEnd
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cbRememberme = new CheckBox();
            btnLogin = new FastUI.FastUILibrary.Components.FuiButton();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.Luxury_Sports_Car_Wallpapers_for_iPhone;
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(249, 351);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(25, 131);
            label2.Name = "label2";
            label2.Size = new Size(199, 22);
            label2.TabIndex = 1;
            label2.Text = "Management System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(25, 98);
            label1.Name = "label1";
            label1.Size = new Size(194, 24);
            label1.TabIndex = 0;
            label1.Text = "Welcome To DVLD";
            // 
            // label3
            // 
            label3.Font = new Font("SF Pro Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(366, 65);
            label3.Name = "label3";
            label3.Size = new Size(322, 57);
            label3.TabIndex = 1;
            label3.Text = "Login To Your Account";
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(444, 138);
            tbUsername.MaxLength = 20;
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "Enter Your Username";
            tbUsername.Size = new Size(272, 27);
            tbUsername.TabIndex = 2;
            tbUsername.TextChanged += tbUsername_TextChanged;
            tbUsername.Validating += tbUsername_Validating;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(444, 186);
            tbPassword.MaxLength = 20;
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.PlaceholderText = "Enter Your Password";
            tbPassword.Size = new Size(272, 27);
            tbPassword.TabIndex = 3;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(322, 141);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 4;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(324, 191);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 5;
            label5.Text = "Password";
            // 
            // cbRememberme
            // 
            cbRememberme.AutoSize = true;
            cbRememberme.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbRememberme.Location = new Point(455, 234);
            cbRememberme.Name = "cbRememberme";
            cbRememberme.Size = new Size(142, 24);
            cbRememberme.TabIndex = 6;
            cbRememberme.Text = "Remember Me ?";
            cbRememberme.UseVisualStyleBackColor = true;

            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BorderColor = Color.FromArgb(66, 133, 244);
            btnLogin.BorderWidth = 0.8F;
            btnLogin.ControlHeight = 36;
            btnLogin.ControlWidth = 125;
            btnLogin.CornerRadius = 14F;
            btnLogin.FillColor = Color.FromArgb(66, 133, 244);
            btnLogin.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnLogin.FontColor = Color.White;
            btnLogin.FontSize = 10.5F;
            btnLogin.ForeColor = Color.White;
            btnLogin.HoverBorder = Color.FromArgb(52, 115, 220);
            btnLogin.HoverFillColor = Color.FromArgb(52, 115, 220);
            btnLogin.HoverTextColor = Color.White;
            btnLogin.Location = new Point(512, 291);
            btnLogin.MoreFontSettings = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnLogin.MoveTextHorizontal = 0;
            btnLogin.MoveTextVertical = 0;
            btnLogin.Name = "btnLogin";
            btnLogin.PressBorderColor = Color.FromArgb(41, 96, 185);
            btnLogin.PressDepth = 2;
            btnLogin.PressFillColor = Color.FromArgb(41, 96, 185);
            btnLogin.Size = new Size(125, 36);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.TextPosition = FastUI.FastUILibrary.Core.FastTextAlign.Center;
            btnLogin.Theme = "GoogleMaterial";
            btnLogin.Click += btnLogin_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 351);
            Controls.Add(btnLogin);
            Controls.Add(cbRememberme);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - DVLD";
            FormClosing += frmLogin_FormClosing;
            Load += frmLogin_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label label4;
        private Label label5;
        private CheckBox cbRememberme;
        private FastUI.FastUILibrary.Components.FuiButton btnLogin;
        private ErrorProvider errorProvider1;
    }
}