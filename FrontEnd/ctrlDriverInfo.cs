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
    public partial class ctrlDriverLicenseInfo : UserControl
    {
        public ctrlDriverLicenseInfo()
        {
            InitializeComponent();
        }

        private void FillPfp(string Path)
        {
            using (var stream = new FileStream(
Path,
FileMode.Open,
FileAccess.Read,
   FileShare.Read))
            {
                using (var temp = Image.FromStream(stream))
                {
                    this.pbProfile.Image = new Bitmap(temp);
                }
            }
            
        }

        public void FillForm(int ApplicaionID)
        {
            if(!clsCheckExistence.CheckIfTheLicenseHasBeenIssuedOrNot(ApplicaionID))
            {
                MessageBox.Show("The license has not been issued yet.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            DataTable License = clsLicenses.GetDriverLicenseInfoByApplicationID(ApplicaionID);

            foreach (DataRow R in License.Rows)
            {
                this.labClassName.Text = R["ClassName"].ToString();
                this.labName.Text = R["FullName"].ToString();
                this.labLicenseID.Text = R["LicenseID"].ToString();
                this.labNationalNum.Text = R["NationalNumber"].ToString();
                this.labGender.Text = R["Gender"].ToString();
                FillPfp(R["ImagePath"].ToString());

                if (labGender.Text == "M")
                {
                   this.pbGender.Image = Properties.Resources.Man_32;
                }
                else
                {
                    this.pbGender.Image = Properties.Resources.Woman_32;
                }

                this.labIssueDate.Text = DateOnly.FromDateTime(Convert.ToDateTime(R["IssueDate"])).ToString();
                this.labExpDate.Text = DateOnly.FromDateTime(Convert.ToDateTime( R["ExpirationDate"])).ToString("dd/MM/yyyy");
                this.labIsActive.Text = R["IsActive"].ToString();
                this.labDriverID.Text = R["DriverID"].ToString();
                this.labDateOfBirth.Text = DateOnly.FromDateTime(Convert.ToDateTime(R["DateOfBirth"])).ToString("dd/MM/yyyy");
                this.labNotes.Text = R["Notes"]?.ToString();
                this.labIssueReason.Text = R["IssueReason"].ToString();

                break;
            }


        }


    }
}
