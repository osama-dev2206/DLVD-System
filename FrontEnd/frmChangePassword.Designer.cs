namespace FrontEnd
{
    partial class frmChangePassword
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
            ctrlPersonInfo1 = new ctrlPersonInfo();
            ctrlShowUserInfo1 = new ctrlShowUserInfo();
            SuspendLayout();
            // 
            // ctrlPersonInfo1
            // 
            ctrlPersonInfo1.Location = new Point(14, 30);
            ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            ctrlPersonInfo1.Size = new Size(912, 301);
            ctrlPersonInfo1.TabIndex = 0;
            // 
            // ctrlShowUserInfo1
            // 
            ctrlShowUserInfo1.Location = new Point(33, 337);
            ctrlShowUserInfo1.Name = "ctrlShowUserInfo1";
            ctrlShowUserInfo1.Size = new Size(862, 115);
            ctrlShowUserInfo1.TabIndex = 1;
            // 
            // frmChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 706);
            Controls.Add(ctrlShowUserInfo1);
            Controls.Add(ctrlPersonInfo1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmChangePassword";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Change Password";
            ResumeLayout(false);
        }

        #endregion

        private ctrlPersonInfo ctrlPersonInfo1;
        private ctrlShowUserInfo ctrlShowUserInfo1;
    }
}