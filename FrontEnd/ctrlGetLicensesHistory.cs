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
    public partial class ctrlGetLicensesHistory : UserControl
    {
        public ctrlGetLicensesHistory()
        {
            InitializeComponent();
        }

        void LocalLicenseView(int ApplicantID)
        {
            this.DgvLocal.DataSource = clsLicenses.GetAllLicenseByApplicantID(ApplicantID);
            this.labCountOfRecordsLocal.Text = this.DgvLocal.Rows.Count.ToString();
        }

        void InternationalLicenseView(int ApplicantID)
        {
            this.DgvInternational.DataSource = clsInternationalLicense.GetInternationalLicenseDataView(ApplicantID);  // ApplicantID is the same as PersonID in this case
            this.labCountOfRecordsInternational.Text = this.DgvInternational.Rows.Count.ToString();
        }

        public void FillLicensesHistory(int ApplicantID)
        {
            LocalLicenseView(ApplicantID);
            InternationalLicenseView(ApplicantID);
        }


    }
}
