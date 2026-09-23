namespace FrontEnd
{
    partial class frmShowLocalDrivingLicApplicationDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowLocalDrivingLicApplicationDetails));
            label1 = new Label();
            ctrlApplicationInfo1 = new CtrlApplicationInfo();
            label2 = new Label();
            label3 = new Label();
            labLocalAppId = new Label();
            labClassName = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 58);
            label1.TabIndex = 0;
            label1.Text = "Application Info";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ctrlApplicationInfo1
            // 
            ctrlApplicationInfo1.Location = new Point(27, 61);
            ctrlApplicationInfo1.Name = "ctrlApplicationInfo1";
            ctrlApplicationInfo1.Size = new Size(737, 279);
            ctrlApplicationInfo1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 378);
            label2.Name = "label2";
            label2.Size = new Size(108, 23);
            label2.TabIndex = 2;
            label2.Text = "Class Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(57, 343);
            label3.Name = "label3";
            label3.Size = new Size(175, 23);
            label3.TabIndex = 3;
            label3.Text = "LocaL Application ID :";
            // 
            // labLocalAppId
            // 
            labLocalAppId.AutoSize = true;
            labLocalAppId.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labLocalAppId.Location = new Point(239, 343);
            labLocalAppId.Name = "labLocalAppId";
            labLocalAppId.Size = new Size(27, 23);
            labLocalAppId.TabIndex = 4;
            labLocalAppId.Text = "-1";
            // 
            // labClassName
            // 
            labClassName.AutoSize = true;
            labClassName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labClassName.Location = new Point(173, 378);
            labClassName.Name = "labClassName";
            labClassName.Size = new Size(24, 23);
            labClassName.TabIndex = 5;
            labClassName.Text = "??";
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_321;
            btnClose.ImageAlign = ContentAlignment.BottomLeft;
            btnClose.Location = new Point(650, 404);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(142, 42);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // frmShowLocalDrivingLicApplicationDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(labClassName);
            Controls.Add(labLocalAppId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ctrlApplicationInfo1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmShowLocalDrivingLicApplicationDetails";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Local Driving License Application Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CtrlApplicationInfo ctrlApplicationInfo1;
        private Label label2;
        private Label label3;
        private Label labLocalAppId;
        private Label labClassName;
        private Button btnClose;
    }
}