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
            labFormState = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            lblPersonID = new Label();
            ctrlAddEditPerson1 = new ctrlAddEditPerson(this.PersonID);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // labFormState
            // 
            labFormState.Dock = DockStyle.Top;
            labFormState.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            labFormState.ForeColor = Color.Red;
            labFormState.Location = new Point(0, 0);
            labFormState.Name = "labFormState";
            labFormState.Size = new Size(1101, 48);
            labFormState.TabIndex = 0;
            labFormState.Text = "Add New Person";
            labFormState.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 57);
            label1.Name = "label1";
            label1.Size = new Size(95, 23);
            label1.TabIndex = 1;
            label1.Text = "PersonID : ";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Image = Properties.Resources.Number_32;
            pictureBox3.Location = new Point(121, 51);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 34);
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // lblPersonID
            // 
            lblPersonID.AutoSize = true;
            lblPersonID.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPersonID.Location = new Point(175, 58);
            lblPersonID.Name = "lblPersonID";
            lblPersonID.Size = new Size(21, 20);
            lblPersonID.TabIndex = 15;
            lblPersonID.Text = "??";
            // 
            // ctrlAddEditPerson1
            // 
            ctrlAddEditPerson1.Location = new Point(12, 81);
            ctrlAddEditPerson1.Name = "ctrlAddEditPerson1";
            ctrlAddEditPerson1.Size = new Size(1082, 377);
            ctrlAddEditPerson1.TabIndex = 16;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.Close_321;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(910, 455);
            button1.Name = "button1";
            button1.Size = new Size(179, 44);
            button1.TabIndex = 17;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnClose_Click;
            // 
            // frmAddEditPerson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1101, 511);
            Controls.Add(button1);
            Controls.Add(ctrlAddEditPerson1);
            Controls.Add(lblPersonID);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(labFormState);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddEditPerson";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddEditPerson";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labFormState;
        private Label label1;
        private PictureBox pictureBox3;
        private Label lblPersonID;
        private ctrlAddEditPerson ctrlAddEditPerson1;
        private Button button1;
    }
}