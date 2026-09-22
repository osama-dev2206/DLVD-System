using BussinessLogicLayer;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class frmAddEditLocalDrivingLicense : Form
    {
        enum enFormStatus : byte { Add = 1, Edit = 2 }
        enFormStatus formStatus;
        private clsLocalDrivingLicenseApplications? NewLocalDrivingLicenseApplication; // instance of the class to hold the new local driving license application data
        public frmAddEditLocalDrivingLicense(int ApplicationID)
        {
            if (!int.TryParse(ApplicationID.ToString(), out _))
            {
                MessageBox.Show("Invalid Application ID. Please provide a valid Application ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            InitializeComponent();

            btnNext.Enabled = false; // disable the Next button by default
            btnSave.Enabled = false; // disable the Save button by default

            this.ctrlFilterFindBy.OnPersonFound += GetPersonFoundedOrAdded; // subscribe to the event when a person is found or added in the ctrlFilterFindBy2 control

            this.ctrlFilterFindBy.OnPersonNationalNoOrPersonIDIsNotValid += GetPersonNotFoundError; // subscribe to the event when a person is not found in the ctrlFilterFindBy2 control

            if (ApplicationID == -1)
            {
                this.formStatus = enFormStatus.Add;
      
            }
            else
            {
                this.formStatus = enFormStatus.Edit;
            }

        }

        void FillCbWithLicenseClasses() // fill the combobox with license classes
        {
            DataTable dt = clsLicenseClasses.GetAll_LicenseClassses();
            foreach (DataRow R in dt.Rows)
            {
                this.cbLicenseClass.Items.Add(R["ClassName"]?.ToString());
            }
        }

        void GetPersonFoundedOrAdded(int PersonID) // EVENT when a person is found or added, this method will be called
        {
            this.ctrlPersonInfo1.LoadInfoUsingPersonID(PersonID);
            FillCbWithLicenseClasses(); // as the person has found so we can fill the combobox with license classes
            this.btnNext.Enabled = true; // enable the Next button when a person is found or added
            this.btnSave.Enabled = true; // enable the Save button when a person is found or added

            NewLocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplications(PersonID); // create a new instance of the class to hold the new local driving license application data

            FillApplicationInfo(); // fill the form with the BASIC application info 
        }

        void FillApplicationInfo()
        {
            if (this.NewLocalDrivingLicenseApplication is not null)
            {
                this.cbLicenseClass.SelectedIndex = 2; // the default is ordinary driving license class 
                this.labDateTime.Text = this.NewLocalDrivingLicenseApplication.Application.ApplicationDateTime.ToString();
                this.labAppFess.Text = this.NewLocalDrivingLicenseApplication.Application.PaiedFee.ToString();
                this.labCreatedBy.Text = clsCurrentLoggedInUser.User.Username;
            }
        }

        void GetPersonNotFoundError(bool status, string message) // Event 
        {
            MessageBox.Show(message, "Person Not Found Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.ctrlPersonInfo1.RestToDefault();
        }

        private void cbLicenseClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbLicenseClass.SelectedIndex !=-1)
            {
                this.NewLocalDrivingLicenseApplication.LicenseClassID = clsLicenseClasses.GetLicenseClassIDByClassName(cbLicenseClass.SelectedItem.ToString());
            }
        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedIndex = 1;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = !btnNext.Enabled;
        }



        //private void lblEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    frmAddEditPerson frmEdit = new frmAddEditPerson(user.PersonID);
        //    frmEdit.ShowDialog();
        //    frmEdit.Dispose();
        //    this.ctrlPersonInfo1.LoadInfoUsingPersonID(user.PersonID); // reload the person
        //}



    }

}
