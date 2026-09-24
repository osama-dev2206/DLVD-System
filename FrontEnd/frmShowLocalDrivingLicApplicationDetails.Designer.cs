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
            btnClose = new Button();
            ctrlLcoalDrivingLicenseInfo1 = new ctrlLocalDrivingLicenseInfo();
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
            ctrlApplicationInfo1.Size = new Size(737, 363);
            ctrlApplicationInfo1.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_321;
            btnClose.ImageAlign = ContentAlignment.BottomLeft;
            btnClose.Location = new Point(646, 679);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(142, 43);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ctrlLcoalDrivingLicenseInfo1
            // 
            ctrlLcoalDrivingLicenseInfo1.Location = new Point(27, 430);
            ctrlLcoalDrivingLicenseInfo1.Name = "ctrlLcoalDrivingLicenseInfo1";
            ctrlLcoalDrivingLicenseInfo1.Size = new Size(737, 199);
            ctrlLcoalDrivingLicenseInfo1.TabIndex = 7;
            // 
            // frmShowLocalDrivingLicApplicationDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 725);
            Controls.Add(ctrlLcoalDrivingLicenseInfo1);
            Controls.Add(btnClose);
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
        }

        #endregion

        private Label label1;
        private CtrlApplicationInfo ctrlApplicationInfo1;
        private Button btnClose;
        private ctrlLocalDrivingLicenseInfo ctrlLcoalDrivingLicenseInfo1;
    }
}