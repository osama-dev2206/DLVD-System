namespace FrontEnd
{
    partial class frmLicenseHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicenseHistory));
            ctrlPersonInfo1 = new ctrlPersonInfo();
            btnClose = new Button();
            ctrlGetLicensesHistory1 = new ctrlGetLicensesHistory();
            SuspendLayout();
            // 
            // ctrlPersonInfo1
            // 
            ctrlPersonInfo1.Location = new Point(5, 0);
            ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            ctrlPersonInfo1.Size = new Size(956, 311);
            ctrlPersonInfo1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 2;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_321;
            btnClose.ImageAlign = ContentAlignment.BottomLeft;
            btnClose.Location = new Point(779, 646);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(217, 51);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ctrlGetLicensesHistory1
            // 
            ctrlGetLicensesHistory1.Location = new Point(15, 315);
            ctrlGetLicensesHistory1.Name = "ctrlGetLicensesHistory1";
            ctrlGetLicensesHistory1.Size = new Size(1048, 312);
            ctrlGetLicensesHistory1.TabIndex = 3;
            // 
            // frmLicenseHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1087, 699);
            Controls.Add(ctrlGetLicensesHistory1);
            Controls.Add(btnClose);
            Controls.Add(ctrlPersonInfo1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLicenseHistory";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "License History";
            ResumeLayout(false);
        }

        #endregion

        private ctrlPersonInfo ctrlPersonInfo1;
        private Button btnClose;
        private ctrlGetLicensesHistory ctrlGetLicensesHistory1;
    }
}