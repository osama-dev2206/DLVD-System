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
                this.labFormStatus.Text = "New Local Driving License Application";
                this.formStatus = enFormStatus.Add;

            }
            else
            {
                this.formStatus = enFormStatus.Edit;
                this.labFormStatus.Text = "Edit Local Driving License Application";
                this.ctrlFilterFindBy.Enabled = false;
                // find the local driving license application by application id
                this.NewLocalDrivingLicenseApplication = clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplicationByLocalID(ApplicationID);
                
                if(NewLocalDrivingLicenseApplication is null)
                {
                    MessageBox.Show("Failed To Get Form Info Please Check Your Application ID If Exists Or Not !", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                this.ctrlPersonInfo1.LoadInfoUsingPersonID(this.NewLocalDrivingLicenseApplication.Application.ApplicantPersonID);
                FillCbWithLicenseClasses();
                FillApplicationInfo();
                btnNext.Enabled = true;
                btnSave.Enabled = true;
                labEditPerson.Enabled = true;
                this.labApplicationID.Text = this.NewLocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
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
            this.labEditPerson.Enabled = true; // as the person has found so we can enable the edit person link label

            NewLocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplications(PersonID); // create a new instance of the class to hold the new local driving license application data
            NewLocalDrivingLicenseApplication.OnSaveErrorGetMessage += OnSaveGetMessage;
            NewLocalDrivingLicenseApplication.OnSaveSuccessGetAppID += UpdateLDLAppId;

            FillApplicationInfo(); // fill the form with the BASIC application info 
        }

        void FillApplicationInfo()
        {
            if (this.NewLocalDrivingLicenseApplication is not null)
            {
               if(this.formStatus == enFormStatus.Add) 
                {
                    this.cbLicenseClass.SelectedIndex = 2; // the default is ordinary driving license class
                 }
               else if(this.formStatus == enFormStatus.Edit)
                {
                    this.cbLicenseClass.Text = clsLicenseClasses.FindLicenseClassByID(this.NewLocalDrivingLicenseApplication.LicenseClassID).ClassName;
                }

                this.labDateTime.Text = this.NewLocalDrivingLicenseApplication.Application.ApplicationDateTime.ToString(); // creation date time
                this.labAppFess.Text = this.NewLocalDrivingLicenseApplication.Application.PaiedFee.ToString();

                if (this.formStatus == enFormStatus.Add)
                {
                    this.labCreatedBy.Text = clsCurrentLoggedInUser.User.Username;
                }
                else if (this.formStatus == enFormStatus.Edit)
                {
                    this.labCreatedBy.Text = clsUsers.FindUserByUserIDAsObj(this.NewLocalDrivingLicenseApplication.Application.CreatedByUserID).Username;
                }
            }
        }

        void GetPersonNotFoundError(bool status, string message) // Event 
        {
            MessageBox.Show(message, "Person Not Found Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.labEditPerson.Enabled = false; // as the person has found so we can enable the edit person link label
            this.ctrlPersonInfo1.RestToDefault();
        }

        private void cbLicenseClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLicenseClass.SelectedIndex != -1)
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


        private void linkLabelEditPerson_Click(object sender, EventArgs e)
        {
            int ID = this.NewLocalDrivingLicenseApplication.Application.ApplicantPersonID;
            frmAddEditPerson frmEdit = new frmAddEditPerson(ID);
            frmEdit.ShowDialog();
            frmEdit.Dispose();
            this.ctrlPersonInfo1.LoadInfoUsingPersonID(ID); // reload the person
        }

        string ErrorMessage = string.Empty;
        void OnSaveGetMessage(string message) // methods that raises when the save gets error
        {
            ErrorMessage = message;
        }

        void UpdateLDLAppId(int AppId)
        {
            this.labApplicationID.Text = AppId.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (this.formStatus)
            { 
                case enFormStatus.Add:
                {
                    if (this.NewLocalDrivingLicenseApplication.SaveLocalDrivingLicenseApplication())
                    {
                        MessageBox.Show("Local Driving License Application saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.formStatus = enFormStatus.Edit;
                            this.labFormStatus.Text = "Edit Local Driving License Application";

                        }
                    else
                    {
                        MessageBox.Show(this.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    break;
                }

                case enFormStatus.Edit:
                    {
                        if(this.NewLocalDrivingLicenseApplication.SaveLocalDrivingLicenseApplication())
                        {
                            MessageBox.Show("Local Driving License Application updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(this.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
            }
        }


    }

}
