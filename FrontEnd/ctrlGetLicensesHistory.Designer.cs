namespace FrontEnd
{
    partial class ctrlGetLicensesHistory
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            labCountOfRecordsLocal = new Label();
            label1 = new Label();
            DgvLocal = new DataGridView();
            tabPage2 = new TabPage();
            label4 = new Label();
            labCountOfRecordsInternational = new Label();
            label3 = new Label();
            DgvInternational = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvLocal).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvInternational).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(3, 6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1038, 327);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(labCountOfRecordsLocal);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(DgvLocal);
            tabPage1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1030, 294);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Local";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 18);
            label2.Name = "label2";
            label2.Size = new Size(189, 23);
            label2.TabIndex = 3;
            label2.Text = "Local Licenses History ";
            // 
            // labCountOfRecordsLocal
            // 
            labCountOfRecordsLocal.AutoSize = true;
            labCountOfRecordsLocal.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            labCountOfRecordsLocal.Location = new Point(109, 257);
            labCountOfRecordsLocal.Name = "labCountOfRecordsLocal";
            labCountOfRecordsLocal.Size = new Size(22, 25);
            labCountOfRecordsLocal.TabIndex = 2;
            labCountOfRecordsLocal.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(6, 257);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 1;
            label1.Text = "#Records :";
            // 
            // DgvLocal
            // 
            DgvLocal.AllowUserToAddRows = false;
            DgvLocal.AllowUserToDeleteRows = false;
            DgvLocal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvLocal.BackgroundColor = Color.White;
            DgvLocal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvLocal.Location = new Point(6, 44);
            DgvLocal.Name = "DgvLocal";
            DgvLocal.ReadOnly = true;
            DgvLocal.RowHeadersWidth = 51;
            DgvLocal.Size = new Size(1018, 196);
            DgvLocal.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(labCountOfRecordsInternational);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(DgvInternational);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1030, 294);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "International";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 20);
            label4.Name = "label4";
            label4.Size = new Size(182, 23);
            label4.TabIndex = 6;
            label4.Text = "International Licenses";
            // 
            // labCountOfRecordsInternational
            // 
            labCountOfRecordsInternational.AutoSize = true;
            labCountOfRecordsInternational.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labCountOfRecordsInternational.Location = new Point(112, 257);
            labCountOfRecordsInternational.Name = "labCountOfRecordsInternational";
            labCountOfRecordsInternational.Size = new Size(24, 28);
            labCountOfRecordsInternational.TabIndex = 5;
            labCountOfRecordsInternational.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(9, 257);
            label3.Name = "label3";
            label3.Size = new Size(110, 28);
            label3.TabIndex = 4;
            label3.Text = "#Records :";
            // 
            // DgvInternational
            // 
            DgvInternational.AllowUserToAddRows = false;
            DgvInternational.AllowUserToDeleteRows = false;
            DgvInternational.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvInternational.BackgroundColor = Color.White;
            DgvInternational.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvInternational.Location = new Point(9, 46);
            DgvInternational.Name = "DgvInternational";
            DgvInternational.ReadOnly = true;
            DgvInternational.RowHeadersWidth = 51;
            DgvInternational.Size = new Size(1015, 197);
            DgvInternational.TabIndex = 3;
            // 
            // ctrlGetLicensesHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "ctrlGetLicensesHistory";
            Size = new Size(1044, 333);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvLocal).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvInternational).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView DgvLocal;
        private Label label1;
        private Label labCountOfRecordsLocal;
        private Label labCountOfRecordsInternational;
        private Label label3;
        private DataGridView DgvInternational;
        private Label label2;
        private Label label4;
    }
}
