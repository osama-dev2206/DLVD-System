namespace FrontEnd
{
    partial class ctrlFilterFindBy
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
            tbSeach = new TextBox();
            pbSearch = new PictureBox();
            pbAdd = new PictureBox();
            cbFilter = new ComboBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAdd).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbSeach);
            groupBox1.Controls.Add(pbSearch);
            groupBox1.Controls.Add(pbAdd);
            groupBox1.Controls.Add(cbFilter);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(18, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(822, 79);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // tbSeach
            // 
            tbSeach.Location = new Point(326, 31);
            tbSeach.Name = "tbSeach";
            tbSeach.Size = new Size(250, 27);
            tbSeach.TabIndex = 4;
            tbSeach.TextChanged += tbSeach_TextChanged;
            // 
            // pbSearch
            // 
            pbSearch.Image = Properties.Resources.SearchPerson;
            pbSearch.Location = new Point(596, 21);
            pbSearch.Name = "pbSearch";
            pbSearch.Size = new Size(58, 47);
            pbSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pbSearch.TabIndex = 3;
            pbSearch.TabStop = false;
            pbSearch.Click += pbSearch_Click;
            // 
            // pbAdd
            // 
            pbAdd.Image = Properties.Resources.AddPerson_32;
            pbAdd.Location = new Point(688, 21);
            pbAdd.Name = "pbAdd";
            pbAdd.Size = new Size(58, 47);
            pbAdd.SizeMode = PictureBoxSizeMode.Zoom;
            pbAdd.TabIndex = 2;
            pbAdd.TabStop = false;
            pbAdd.Click += pbAdd_Click;
            // 
            // cbFilter
            // 
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "NationalNO", "PersonID" });
            cbFilter.Location = new Point(150, 30);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(157, 28);
            cbFilter.TabIndex = 1;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 29);
            label1.Name = "label1";
            label1.Size = new Size(106, 31);
            label1.TabIndex = 0;
            label1.Text = "Find By :";
            // 
            // ctrlFilterFindBy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "ctrlFilterFindBy";
            Size = new Size(856, 113);
            KeyPress += ctrlFilterFindBy_KeyPress;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAdd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cbFilter;
        private PictureBox pbSearch;
        private PictureBox pbAdd;
        private TextBox tbSeach;
    }
}
