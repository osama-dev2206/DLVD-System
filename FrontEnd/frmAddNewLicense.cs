using BussinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class frmAddNewLicense : Form
    {
        clsLicenses? NewLicense;
        public frmAddNewLicense(int LocalDrivingLicenseAppID)
        {
            InitializeComponent();

            clsLocalDrivingLicenseApplications LocalApp = clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplicationByLocalID(LocalDrivingLicenseAppID);

            this.ctrlApplicationInfo1.FillCtrlInfoByApplicationID(ApplicationID:  LocalApp.Application.ApplicationID);
            this.ctrlLocalDrivingLicenseInfo1.FillForm(LocalDrivingLicenseAppID);

       
            NewLicense = new clsLicenses(ApplicationID: LocalApp.Application.ApplicationID, LicenseClassID: LocalApp.LicenseClassID);
            NewLicense.OnSaveGetError += GetErrorMessage;
            NewLicense.GetLicenseIDAfterSaving += GetSavedLicenseID;
        }

        private void tbNotes_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbNotes.Text))
            {
                NewLicense.Notes = tbNotes.Text;
            }
        }

        void GetErrorMessage(string Message)
        {
            MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void GetSavedLicenseID(int LicenseID)
        {
            MessageBox.Show($"License saved successfully with ID: {LicenseID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            this.NewLicense.Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
