namespace FrontEnd
{
    partial class ctrlFilterFindLicenseByLicID
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
            pbSearch = new PictureBox();
            tbID = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pbSearch);
            groupBox1.Controls.Add(tbID);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(645, 73);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // pbSearch
            // 
            pbSearch.Image = Properties.Resources.License_View_321;
            pbSearch.Location = new Point(565, 22);
            pbSearch.Name = "pbSearch";
            pbSearch.Size = new Size(61, 43);
            pbSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pbSearch.TabIndex = 2;
            pbSearch.TabStop = false;
            pbSearch.Click += pbSearch_Click;
            // 
            // tbID
            // 
            tbID.Location = new Point(200, 30);
            tbID.Name = "tbID";
            tbID.Size = new Size(348, 27);
            tbID.TabIndex = 1;
            tbID.KeyPress += tbID_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 23);
            label1.Name = "label1";
            label1.Size = new Size(175, 41);
            label1.TabIndex = 0;
            label1.Text = "License ID :";
            // 
            // ctrlFilterFindLicenseByLicID
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "ctrlFilterFindLicenseByLicID";
            Size = new Size(651, 79);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox tbID;
        private PictureBox pbSearch;
    }
}
