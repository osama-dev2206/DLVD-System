namespace FrontEnd
{
    partial class frmAddEditPerson
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
            ctrlAddEditPerson1 = new ctrlAddEditPerson();
            label1 = new Label();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            lblPersonID = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // ctrlAddEditPerson1
            // 
            ctrlAddEditPerson1.Location = new Point(19, 126);
            ctrlAddEditPerson1.Name = "ctrlAddEditPerson1";
            ctrlAddEditPerson1.Size = new Size(1075, 388);
            ctrlAddEditPerson1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1106, 71);
            label1.TabIndex = 1;
            label1.Text = "Add New Person";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 92);
            label2.Name = "label2";
            label2.Size = new Size(95, 23);
            label2.TabIndex = 2;
            label2.Text = "Person ID :";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Image = Properties.Resources.Number_321;
            pictureBox4.Location = new Point(133, 86);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(34, 34);
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // lblPersonID
            // 
            lblPersonID.AutoSize = true;
            lblPersonID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPersonID.Location = new Point(179, 89);
            lblPersonID.Name = "lblPersonID";
            lblPersonID.Size = new Size(28, 28);
            lblPersonID.TabIndex = 20;
            lblPersonID.Text = "-1";
            // 
            // frmAddEditPerson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 526);
            Controls.Add(lblPersonID);
            Controls.Add(pictureBox4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ctrlAddEditPerson1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddEditPerson";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddEditPerson";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlAddEditPerson ctrlAddEditPerson1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox4;
        private Label lblPersonID;
    }
}