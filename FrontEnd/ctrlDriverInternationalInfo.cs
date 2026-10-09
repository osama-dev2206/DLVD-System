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
    public partial class ctrlDriverInternationalInfo : UserControl
    {
        public ctrlDriverInternationalInfo()
        {
            InitializeComponent();
        }

        void ChangeGenderPfp()
        {
            if(labGender.Text == "Male")
            {
                pbGender.Image = Properties.Resources.Man_32;
            }
            else if (labGender.Text == "Female")
            {
                pbGender.Image = Properties.Resources.Woman_32;
            }
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
                    this.pbPfp.Image = new Bitmap(temp);
                }
            }

        
        }

        internal Action<bool> OnFailedToGetLicenseInfo;

         // International License 
        internal void FillForm(int LicenseID)
        {
            
            DataTable dt = clsInternationalLicense.GetInternationalLicenseInfo(LicenseID);

            if(dt.Columns.Count ==0 )
            {
                OnFailedToGetLicenseInfo?.Invoke(true);
                return;
            }

            foreach (DataRow dr in dt.Rows)
            {
                labFullName.Text = dr["FullName"].ToString();
                labIntLicID.Text = dr["InternationalLicenseID"].ToString();
                labLicID.Text = dr["LicenseID"].ToString(); // 2
                labNationalNo.Text = dr["NationalNumber"].ToString();
                labGender.Text = dr["Gender"].ToString();
                ChangeGenderPfp();
                labIssueDate.Text =DateOnly.FromDateTime(Convert.ToDateTime(dr["IssueDateTime"])) .ToString();
                labAppID.Text = dr["ApplicationID"].ToString();
                labIsActive.Text = dr["IsActive"].ToString();
                labDateOfBirth.Text = DateOnly.FromDateTime(Convert.ToDateTime(dr["DateOfBirth"])).ToString();
                labDriverID.Text = dr["DriverID"].ToString();
                labExpDate.Text = DateOnly.FromDateTime(Convert.ToDateTime(dr["ExpirationDate"])).ToString();

                FillPfp(dr["ImagePath"]?.ToString());
                break;
            }


        }


    }
}
