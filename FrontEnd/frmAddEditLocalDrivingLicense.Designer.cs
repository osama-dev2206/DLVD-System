namespace FrontEnd
{
    partial class frmAddEditLocalDrivingLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditLocalDrivingLicense));
            labFormStatus = new Label();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            labEditPerson = new LinkLabel();
            ctrlPersonInfo1 = new ctrlPersonInfo();
            btnNext = new Button();
            ctrlFilterFindBy = new ctrlFilterFindBy();
            tabPage2 = new TabPage();
            cbLicenseClass = new ComboBox();
            labDateTime = new Label();
            labAppFess = new Label();
            labCreatedBy = new Label();
            labApplicationID = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lab4 = new Label();
            lab5 = new Label();
            lab2 = new Label();
            lab3 = new Label();
            lab1 = new Label();
            btnSave = new Button();
            btnClose = new Button();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labFormStatus
            // 
            labFormStatus.Dock = DockStyle.Top;
            labFormStatus.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labFormStatus.ForeColor = Color.FromArgb(192, 0, 0);
            labFormStatus.Location = new Point(0, 0);
            labFormStatus.Name = "labFormStatus";
            labFormStatus.Size = new Size(928, 75);
            labFormStatus.TabIndex = 0;
            labFormStatus.Text = "New Local Driving License Application";
            labFormStatus.TextAlign = ContentAlignment.TopCenter;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Location = new Point(12, 87);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(904, 515);
            tabControl.TabIndex = 1;
            tabControl.Selecting += tabControl_Selecting;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(labEditPerson);
            tabPage1.Controls.Add(ctrlPersonInfo1);
            tabPage1.Controls.Add(btnNext);
            tabPage1.Controls.Add(ctrlFilterFindBy);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(896, 482);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Person Info";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // labEditPerson
            // 
            labEditPerson.AutoSize = true;
            labEditPerson.Enabled = false;
            labEditPerson.Location = new Point(736, 150);
            labEditPerson.Name = "labEditPerson";
            labEditPerson.Size = new Size(112, 20);
            labEditPerson.TabIndex = 8;
            labEditPerson.TabStop = true;
            labEditPerson.Text = "Edit Person Info";
            labEditPerson.Click += linkLabelEditPerson_Click;
            // 
            // ctrlPersonInfo1
            // 
            ctrlPersonInfo1.Location = new Point(3, 123);
            ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            ctrlPersonInfo1.Size = new Size(893, 300);
            ctrlPersonInfo1.TabIndex = 1;
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
            btnNext.Location = new Point(714, 429);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(176, 46);
            btnNext.TabIndex = 5;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // ctrlFilterFindBy
            // 
            ctrlFilterFindBy.Location = new Point(0, 6);
            ctrlFilterFindBy.Name = "ctrlFilterFindBy";
            ctrlFilterFindBy.Size = new Size(890, 111);
            ctrlFilterFindBy.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cbLicenseClass);
            tabPage2.Controls.Add(labDateTime);
            tabPage2.Controls.Add(labAppFess);
            tabPage2.Controls.Add(labCreatedBy);
            tabPage2.Controls.Add(labApplicationID);
            tabPage2.Controls.Add(pictureBox5);
            tabPage2.Controls.Add(pictureBox4);
            tabPage2.Controls.Add(pictureBox3);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Controls.Add(lab4);
            tabPage2.Controls.Add(lab5);
            tabPage2.Controls.Add(lab2);
            tabPage2.Controls.Add(lab3);
            tabPage2.Controls.Add(lab1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(896, 482);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Application Info";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbLicenseClass
            // 
            cbLicenseClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLicenseClass.FormattingEnabled = true;
            cbLicenseClass.Location = new Point(297, 191);
            cbLicenseClass.Name = "cbLicenseClass";
            cbLicenseClass.Size = new Size(298, 28);
            cbLicenseClass.TabIndex = 19;
            cbLicenseClass.SelectedIndexChanged += cbLicenseClass_SelectedIndexChanged;
            // 
            // labDateTime
            // 
            labDateTime.AutoSize = true;
            labDateTime.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labDateTime.Location = new Point(416, 133);
            labDateTime.Name = "labDateTime";
            labDateTime.Size = new Size(30, 28);
            labDateTime.TabIndex = 18;
            labDateTime.Text = "??";
            // 
            // labAppFess
            // 
            labAppFess.AutoSize = true;
            labAppFess.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labAppFess.Location = new Point(330, 249);
            labAppFess.Name = "labAppFess";
            labAppFess.Size = new Size(30, 28);
            labAppFess.TabIndex = 13;
            labAppFess.Text = "??";
            // 
            // labCreatedBy
            // 
            labCreatedBy.AutoSize = true;
            labCreatedBy.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labCreatedBy.Location = new Point(270, 317);
            labCreatedBy.Name = "labCreatedBy";
            labCreatedBy.Size = new Size(30, 28);
            labCreatedBy.TabIndex = 12;
            labCreatedBy.Text = "??";
            // 
            // labApplicationID
            // 
            labApplicationID.AutoSize = true;
            labApplicationID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labApplicationID.Location = new Point(362, 74);
            labApplicationID.Name = "labApplicationID";
            labApplicationID.Size = new Size(30, 28);
            labApplicationID.TabIndex = 11;
            labApplicationID.Text = "??";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.User_32__2;
            pictureBox5.Location = new Point(193, 307);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(62, 38);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.money_32;
            pictureBox4.Location = new Point(250, 249);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(62, 29);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Renew_Driving_License_32;
            pictureBox3.Location = new Point(215, 191);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(62, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Calendar_321;
            pictureBox2.Location = new Point(330, 133);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Number_32;
            pictureBox1.Location = new Point(282, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lab4
            // 
            lab4.AutoSize = true;
            lab4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab4.Location = new Point(46, 248);
            lab4.Name = "lab4";
            lab4.Size = new Size(203, 31);
            lab4.TabIndex = 5;
            lab4.Text = "Application Fees :";
            // 
            // lab5
            // 
            lab5.AutoSize = true;
            lab5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab5.Location = new Point(46, 306);
            lab5.Name = "lab5";
            lab5.Size = new Size(141, 31);
            lab5.TabIndex = 4;
            lab5.Text = "Created By :";
            // 
            // lab2
            // 
            lab2.AutoSize = true;
            lab2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab2.Location = new Point(46, 132);
            lab2.Name = "lab2";
            lab2.Size = new Size(266, 31);
            lab2.TabIndex = 3;
            lab2.Text = "Application Date Time :";
            // 
            // lab3
            // 
            lab3.AutoSize = true;
            lab3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab3.Location = new Point(46, 190);
            lab3.Name = "lab3";
            lab3.Size = new Size(163, 31);
            lab3.TabIndex = 1;
            lab3.Text = "License Class :";
            // 
            // lab1
            // 
            lab1.AutoSize = true;
            lab1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab1.Location = new Point(46, 74);
            lab1.Name = "lab1";
            lab1.Size = new Size(221, 31);
            lab1.TabIndex = 0;
            lab1.Text = "D.L Application ID :";
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(752, 609);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 52);
            btnSave.TabIndex = 6;
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
            btnClose.Location = new Point(545, 609);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(160, 52);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmAddEditLocalDrivingLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 673);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(tabControl);
            Controls.Add(labFormStatus);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddEditLocalDrivingLicense";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Edit Local Driving License";
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labFormStatus;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnSave;
        private Button btnNext;
        private Button btnClose;
        private ctrlFilterFindBy ctrlFilterFindBy;
        private ctrlPersonInfo ctrlPersonInfo1;
        private Label lab1;
        private Label lab4;
        private Label lab5;
        private Label lab2;
        private Label lab3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label labApplicationID;
        private Label labDateTime;
        private Label labAppFess;
        private Label labCreatedBy;
        private ComboBox cbLicenseClass;
        private LinkLabel labEditPerson;
    }
}