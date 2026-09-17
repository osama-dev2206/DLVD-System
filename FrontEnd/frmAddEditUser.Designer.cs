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
            tabControl = new TabControl();
            tabPersonInfo = new TabPage();
            ctrlFilterFindBy2 = new ctrlFilterFindBy();
            ctrlPersonInfo1 = new ctrlPersonInfo();
            btnNext = new Button();
            tbLoginInfo = new TabPage();
            label1 = new Label();
            btnSave = new Button();
            btnClose = new Button();
            tabControl.SuspendLayout();
            tabPersonInfo.SuspendLayout();
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
            tabControl.Size = new Size(1025, 516);
            tabControl.TabIndex = 0;
            // 
            // tabPersonInfo
            // 
            tabPersonInfo.BackColor = Color.White;
            tabPersonInfo.Controls.Add(ctrlFilterFindBy2);
            tabPersonInfo.Controls.Add(ctrlPersonInfo1);
            tabPersonInfo.Controls.Add(btnNext);
            tabPersonInfo.Location = new Point(4, 29);
            tabPersonInfo.Name = "tabPersonInfo";
            tabPersonInfo.Padding = new Padding(3);
            tabPersonInfo.Size = new Size(1017, 483);
            tabPersonInfo.TabIndex = 0;
            tabPersonInfo.Text = "Person Info";
            // 
            // ctrlFilterFindBy2
            // 
            ctrlFilterFindBy2.Location = new Point(16, 16);
            ctrlFilterFindBy2.Name = "ctrlFilterFindBy2";
            ctrlFilterFindBy2.Size = new Size(983, 112);
            ctrlFilterFindBy2.TabIndex = 4;
            // 
            // ctrlPersonInfo1
            // 
            ctrlPersonInfo1.BackColor = Color.White;
            ctrlPersonInfo1.Location = new Point(0, 121);
            ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            ctrlPersonInfo1.Size = new Size(1011, 304);
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
            btnNext.Location = new Point(813, 431);
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
            tbLoginInfo.Location = new Point(4, 29);
            tbLoginInfo.Name = "tbLoginInfo";
            tbLoginInfo.Padding = new Padding(3);
            tbLoginInfo.Size = new Size(1017, 483);
            tbLoginInfo.TabIndex = 1;
            tbLoginInfo.Text = "LoginInfo";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1043, 62);
            label1.TabIndex = 1;
            label1.Text = "Add New User";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(839, 612);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(176, 52);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnClose.Image = Properties.Resources.Close_321;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(629, 612);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(176, 52);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmAddEditUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1043, 688);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(label1);
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
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPersonInfo;
        private TabPage tbLoginInfo;
        private Label label1;
        private ctrlPersonInfo ctrlPersonInfo1;
        private Button btnNext;
        private Button btnSave;
        private Button btnClose;
        private ctrlFilterFindBy ctrlFilterFindBy2;
    }
}