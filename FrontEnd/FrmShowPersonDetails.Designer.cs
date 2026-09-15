namespace FrontEnd
{
    partial class FrmShowPersonDetails
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
            btnClose = new Button();
            ctrlPersonInfo1 = new ctrlPersonInfo(this.SelectedPersonID);
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(942, 86);
            label1.TabIndex = 1;
            label1.Text = "Person Info";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 2;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_322;
            btnClose.ImageAlign = ContentAlignment.BottomLeft;
            btnClose.Location = new Point(727, 389);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(187, 46);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ctrlPersonInfo1
            // 
            ctrlPersonInfo1.Location = new Point(28, 80);
            ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            ctrlPersonInfo1.Size = new Size(886, 291);
            ctrlPersonInfo1.TabIndex = 4;
            // 
            // FrmShowPersonDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(942, 440);
            Controls.Add(ctrlPersonInfo1);
            Controls.Add(btnClose);
            Controls.Add(label1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmShowPersonDetails";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmShowPersonDetails";
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button btnClose;
        private ctrlPersonInfo ctrlPersonInfo1;
    }
}