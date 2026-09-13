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
            label1.Size = new Size(1325, 86);
            label1.TabIndex = 1;
            label1.Text = "Person Info";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ctrlPersonInfo1
            // 
            ctrlPersonInfo1.Location = new Point(12, 100);
            ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            ctrlPersonInfo1.Size = new Size(1309, 356);
            ctrlPersonInfo1.TabIndex = 2;
            // 
            // FrmShowPersonDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1325, 468);
            Controls.Add(ctrlPersonInfo1);
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
        private ctrlPersonInfo ctrlPersonInfo1;
    }
}