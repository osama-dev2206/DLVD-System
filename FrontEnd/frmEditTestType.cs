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
    public partial class frmEditTestType : Form
    {
        clsTestTypes testTypes;
        public frmEditTestType(int TestTypeID)
        {
            InitializeComponent();

            if (!int.TryParse(TestTypeID.ToString(), out _))
            {
                MessageBox.Show("Invalid Test Type ID provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            testTypes = clsTestTypes.FindTestType(TestTypeID);
            FillForm();
        }

        void FillForm()
        {
            if (testTypes is not null)
            {
                this.labTestTypeId.Text = testTypes.TestTypeID.ToString();
                this.tbDescription.Text = testTypes.TestTypeDescription;
                tbTitle.Text = testTypes.TestTypeTitle;
                tbFees.Text = testTypes.TestTypeFee.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbTitle.Text))
            {
                this.testTypes.TestTypeTitle = tbTitle.Text;
            }
        }

        private void tbDescription_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbDescription.Text))
            {
                this.testTypes.TestTypeDescription = tbDescription.Text;
            }
        }

        private void tbFees_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbFees.Text) && Decimal.TryParse(tbFees.Text, out decimal fees) && fees > 0)
            {
                this.testTypes.TestTypeFee = fees;
            }
        }

        private void tbTitleAndDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
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
            return !string.IsNullOrEmpty(tbTitle.Text) && !string.IsNullOrEmpty(tbDescription.Text) && !string.IsNullOrEmpty(tbFees.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckBeforeSave())
            {
                if(this.testTypes.Save())
                {
                    MessageBox.Show("Test Type updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update Test Type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }



    }
}
