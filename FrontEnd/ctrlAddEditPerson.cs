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
    public partial class ctrlAddEditPerson : UserControl
    {
        public ctrlAddEditPerson()
        {
            InitializeComponent();
        }

        private void ctrlAddEditPerson_Load(object sender, EventArgs e)
        {
             
        }

        void FillCountriesInComboBox()
        {
            foreach(DataRow R in clsPeople.GetAllCountries().Rows)
            {
                this.cbCountry.Items.Add(R["CountryName"].ToString() );
            }
        }

    }
}
