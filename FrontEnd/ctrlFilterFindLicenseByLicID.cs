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
    public partial class ctrlFilterFindLicenseByLicID : UserControl
    {
        public ctrlFilterFindLicenseByLicID()
        {
            InitializeComponent();
        }

        private void tbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        clsLicenses?  Lic = null;
        private void pbSearch_Click(object sender, EventArgs e)
        {
            if( !String.IsNullOrEmpty(tbID.Text ))
            {
                Lic= clsLicenses.GetLicenseObjByLicenseID(Convert.ToInt32(tbID.Text));
                if (Lic is not null)
                {
                    OnActionGetLicenseObjByLicID?.Invoke(Lic);
                }
                else
                {
                    OnError?.Invoke(true);
                    MessageBox.Show("No license found with the provided ID.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        internal Action<clsLicenses> OnActionGetLicenseObjByLicID;
        internal Action<bool> OnError;
    }
}
