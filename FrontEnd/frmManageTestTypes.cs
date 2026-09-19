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
    public partial class frmManageTestTypes : Form
    {
        int selectedRowIndex = -1;
        public frmManageTestTypes()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            DataTable dt = clsTestTypes.GetAllTestTypes();
            if (dt != null && dt.Rows.Count > 0)
            {
                this.dgvTestTypes.DataSource = dt;
                this.labCountOfRecords.Text = dgvTestTypes.Rows.Count.ToString();
            }
            else
            {
                dgvTestTypes.DataSource = null;
                this.labCountOfRecords.Text = "0";
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditTestType frmEditTest = new frmEditTestType(this.selectedRowIndex);
            frmEditTest.ShowDialog();
            frmEditTest.Dispose();
            RefreshDataGridView();
        }

        private void dgvTestTypes_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgvTestTypes.CurrentRow != null && dgvTestTypes.CurrentRow.Cells != null && int.TryParse(dgvTestTypes.CurrentRow.Cells[0]?.Value?.ToString(), out int Row))
            {
                selectedRowIndex = Row;
            } 
        }



    }
}
