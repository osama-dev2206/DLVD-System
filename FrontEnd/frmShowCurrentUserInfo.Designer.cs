using BussinessLogicLayer;

namespace FrontEnd
{
    partial class frmShowCurrentUserInfo
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
            ctrlPersonInfo1 = new ctrlPersonInfo(this.UserPersonID);
            btnClose = new Button();
            ctrlShowUserInfo1 = new ctrlShowUserInfo(this.UserID);
            SuspendLayout();
            // 
            // ctrlPersonInfo1
            // 
            ctrlPersonInfo1.Location = new Point(10, 12);
            ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            ctrlPersonInfo1.Size = new Size(903, 325);
            ctrlPersonInfo1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Image = Properties.Resources.Close_321;
            btnClose.ImageAlign = ContentAlignment.BottomLeft;
            btnClose.Location = new Point(753, 430);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(160, 45);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ctrlShowUserInfo1
            // 
            ctrlShowUserInfo1.Location = new Point(10, 311);
            ctrlShowUserInfo1.Name = "ctrlShowUserInfo1";
            ctrlShowUserInfo1.Size = new Size(834, 96);
            ctrlShowUserInfo1.TabIndex = 2;
            // 
            // frmShowCurrentUserInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 477);
            Controls.Add(ctrlShowUserInfo1);
            Controls.Add(btnClose);
            Controls.Add(ctrlPersonInfo1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmShowCurrentUserInfo";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Current User Info";
            ResumeLayout(false);
        }

        #endregion

        private ctrlPersonInfo ctrlPersonInfo1;
        private Button btnClose;
        private ctrlShowUserInfo ctrlShowUserInfo1;


    }
}