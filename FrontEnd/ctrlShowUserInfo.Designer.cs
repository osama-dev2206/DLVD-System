namespace FrontEnd
{
    partial class ctrlShowUserInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            labIsActive = new Label();
            label3 = new Label();
            labUsername = new Label();
            label2 = new Label();
            labUserID = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labIsActive);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(labUsername);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(labUserID);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(798, 76);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Info";
            // 
            // labIsActive
            // 
            labIsActive.AutoSize = true;
            labIsActive.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labIsActive.Location = new Point(736, 32);
            labIsActive.Name = "labIsActive";
            labIsActive.Size = new Size(24, 28);
            labIsActive.TabIndex = 5;
            labIsActive.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(631, 32);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 4;
            label3.Text = "Is Active :";
            // 
            // labUsername
            // 
            labUsername.AutoSize = true;
            labUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labUsername.Location = new Point(409, 32);
            labUsername.Name = "labUsername";
            labUsername.Size = new Size(30, 28);
            labUsername.TabIndex = 3;
            labUsername.Text = "??";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(282, 32);
            label2.Name = "label2";
            label2.Size = new Size(121, 28);
            label2.TabIndex = 2;
            label2.Text = "Username : ";
            // 
            // labUserID
            // 
            labUserID.AutoSize = true;
            labUserID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labUserID.Location = new Point(142, 32);
            labUserID.Name = "labUserID";
            labUserID.Size = new Size(24, 28);
            labUserID.TabIndex = 1;
            labUserID.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 32);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 0;
            label1.Text = "User ID : ";
            // 
            // ctrlShowUserInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "ctrlShowUserInfo";
            Size = new Size(820, 102);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label labUserID;
        private Label label2;
        private Label labUsername;
        private Label label3;
        private Label labIsActive;
    }
}
