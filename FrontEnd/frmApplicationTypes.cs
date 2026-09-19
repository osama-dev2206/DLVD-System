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
    public partial class frmApplicationTypes : Form
    {
        int selectedRowIndex = -1;
        public frmApplicationTypes()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            DataTable dt = clsApplicationTypes.GetAllAppTypes();
            if (dt != null && dt.Rows.Count > 0)
            {
                this.dgvApplicationTypes.DataSource = dt;
                this.labCountOfRecords.Text = dgvApplicationTypes.Rows.Count.ToString();
            }
            else
            {
                dgvApplicationTypes.DataSource = null;
                this.labCountOfRecords.Text = "0";
            }
        }

        private void dgvApplicationTypes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvApplicationTypes.CurrentRow != null && dgvApplicationTypes.CurrentRow.Cells != null && int.TryParse(dgvApplicationTypes.CurrentRow.Cells[0]?.Value?.ToString(), out int Row))
            {
                selectedRowIndex = Row;
            }
        }

        clsApplicationTypes App;
        private void editAppToolStripMenuItem_Click(object sender, EventArgs e) // Edit the selected application type
        {
                frmEditApplicationType frmEdit = new frmEditApplicationType(selectedRowIndex);
            frmEdit.ShowDialog();
            frmEdit.Dispose();
        }

    }
}
