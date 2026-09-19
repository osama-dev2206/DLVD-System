using BussinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class frmEditApplicationType : Form
    {
        clsApplicationTypes App;
        public frmEditApplicationType(int ApplicationID)
        {
            InitializeComponent();

            if(!int.TryParse(ApplicationID.ToString() , out _ ) )
           {
                MessageBox.Show("WRONG APPLICATION ID", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            App = clsApplicationTypes.FindAppObjByAppID(ApplicationID);
            FillForm();
        }


        void FillForm()
        {
            this.labAppID.Text = App.ApplicationTypeID.ToString();
            this.tbTitle.Text = App.ApplicationTypeTitle;
            this.tbFees.Text = App.ApplicationFees.ToString();
        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbTitle.Text))
            {
                App.ApplicationTypeTitle = tbTitle.Text;
            }
        }

        private void tbTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbFees_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbFees.Text) && decimal.TryParse(tbFees.Text, out decimal fees) && fees > 0)
            {
                App.ApplicationFees = fees;
            }
        }

        private void tbFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        bool CheckBeforeSave()
        {
            return !String.IsNullOrEmpty(tbTitle.Text) && !String.IsNullOrEmpty(tbFees.Text) && decimal.TryParse(tbFees.Text, out decimal fees) && fees > 0;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckBeforeSave())
            {
                if (this.App.Save())
                {
                    MessageBox.Show("Application Type updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update Application Type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please ensure all fields are filled correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
