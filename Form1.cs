using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace CRM1
{
    public partial class Form1 : Form
    {
        public string getid;

        public string gender;
        public string EducationStatus;
        public string ProfessionalStatus;
        public string Reference;
        public string CourseInterested1 = "";
        public string timeprefered;
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        SqlDataReader dr;
        private void Form1_Load(object sender, EventArgs e)
        {
            clsConsular cl = new clsConsular();

            dt = cl.GetCountry();
            cmbbxCountry.DisplayMember = "CountryName";
            cmbbxCountry.ValueMember = "CountryId";
            cmbbxCountry.DataSource = dt;


            clsConsular p4 = new clsConsular();

            dt = p4.Getgraduation();
            cmbbxgraduation.DisplayMember = "GradName";
            cmbbxgraduation.ValueMember = "GradId";
            cmbbxgraduation.DataSource = dt;


            clsConsular p5 = new clsConsular();

            dt = p5.GetPG();
            cmbbxPG.DisplayMember = "PGName";
            cmbbxPG.ValueMember = "PGId";
            cmbbxPG.DataSource = dt;


            clsConsular obj3 = new clsConsular();
            dt = obj3.GetEnquiry();
            cmbbxEnquirySource.DisplayMember = "EnquirySourceName";
            cmbbxEnquirySource.ValueMember = "EnquirySourceId";
            cmbbxEnquirySource.DataSource = dt;

            DataTable grid = new DataTable();
            grid = obj3.Course();
            grdCourse.DataSource = grid;
            grdCourse.Columns["CourseId"].Visible = false;
            grdCourse.Rows[0].Cells[0].Value = false;
        }



        private void cmbbxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsConsular obj5 = new clsConsular();
            int CountryId = Convert.ToInt32(cmbbxCountry.SelectedValue);
            obj5.CountryId = CountryId;

            dt = obj5.GetState();
            cmbbxstate.DisplayMember = "StateName";
            cmbbxstate.ValueMember = "StateId";
            cmbbxstate.DataSource = dt;
        }

        private void cmbbxstate_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsConsular obj6 = new clsConsular();
            int StateId = Convert.ToInt32(cmbbxstate.SelectedValue);
            obj6.Stateid = StateId;
            dt = obj6.GetCity();
            cmbbxCity.DisplayMember = "CityName";
            cmbbxCity.ValueMember = "CityId";
            cmbbxCity.DataSource = dt;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            clsConsular copy = new clsConsular();

            clsConsular c4 = new clsConsular();
            DataTable dt1 = new DataTable();
            dt1 = c4.GetStud();
            int count = Convert.ToInt32(dt1.Rows[0][0]);
            count = count + 1;
            string studcode = "St" + String.Format("{0:10000}", count);


            if (string.IsNullOrEmpty(txtfullname.Text))
            {
                errorprovider.SetError(txtfullname, "Fullname is required");
                return;
            }
            else
            {
                errorprovider.SetError(txtfullname, string.Empty);
            }
            if (string.IsNullOrEmpty(txtmobileno.Text))
            {
                errorprovider.SetError(txtmobileno, "MobileNo is Required");
                return;
            }
            else
            {
                errorprovider.SetError(txtmobileno, string.Empty);
            }
            if (string.IsNullOrEmpty(txtaltermobileno.Text))
            {
                errorprovider.SetError(txtaltermobileno, "Alter MobileNo is Required");
                return;
            }
            else
            {
                errorprovider.SetError(txtaltermobileno, string.Empty);
            }
            if (string.IsNullOrEmpty(txtemail.Text))
            {
                errorprovider.SetError(txtemail, "Email is required");
            }
            else
            {
                errorprovider.SetError(txtemail, string.Empty);
            }
            if (string.IsNullOrEmpty(rtxtpermanentaddress.Text))
            {
                errorprovider.SetError(rtxtpermanentaddress, "Address must be written");
            }

            else
            {
                errorprovider.SetError(rtxtpermanentaddress, string.Empty);
            }

            if (string.IsNullOrEmpty(rtxtpresentaddress.Text))
            {
                errorprovider.SetError(rtxtpresentaddress, "Present Address must be required");
            }
            else
            {
                errorprovider.SetError(rtxtpresentaddress, string.Empty);
            }
            if (string.IsNullOrEmpty(rtxtpermanentaddress.Text))
            {
                errorprovider.SetError(rtxtpermanentaddress, "permanent Address must be required");
            }
            else
            {
                errorprovider.SetError(rtxtpermanentaddress, string.Empty);
            }

            if (string.IsNullOrEmpty(txtPin.Text))
            {
                errorprovider.SetError(txtPin, "Pin must be required");
            }
            else
            {
                errorprovider.SetError(txtPin, string.Empty);
            }
            if (string.IsNullOrEmpty(txtOther.Text))
            {
                errorprovider.SetError(txtOther, "Pin must be required");
            }
            else
            {
                errorprovider.SetError(txtOther, string.Empty);
            }


            string[] CourseInterested = { };
            string education = "";
            foreach (DataGridViewRow dr in grdCourse.Rows)
            {
                if (dr.Cells[0].Value != null)
                {
                    if ((bool)dr.Cells[0].Value == true)
                    {
                        int row = dr.Cells[0].RowIndex;
                        CourseInterested=CourseInterested.Append(grdCourse.Rows[row].Cells["CourseId"].Value.ToString()).ToArray();
                    }
                }
            }
            copy.EnquiryDate = dateTimePicker1.Value;
            education = string.Join(",", CourseInterested);
            copy.CourseInterested = education;

            string gender = "";
            if (rdbtnFemale.Checked)
            {
                gender = rdbtnFemale.Text;
            }
            else
            {
                gender = rdbtnMale.Text;
            }
            if (rdbtnEmployed.Checked)
            {
                copy.StudProfessionalStatus = rdbtnEmployed.Text;
            }
            else if (rdbtnnonemployed.Checked)
            {
                copy.StudProfessionalStatus = rdbtnnonemployed.Text;

            }
            else
            {
                copy.StudProfessionalStatus = rdbtnStudent.Text;

            }
            copy.StudCode = studcode;
            copy.StudFullName = txtfullname.Text;
            copy.StudContactNo = txtmobileno.Text;
            copy.StudContactNo = txtmobileno.Text;
            copy.StudAlternateNo = txtaltermobileno.Text;
            copy.CityId = Convert.ToInt32(cmbbxCity.SelectedValue.ToString());
            copy.graduationid = Convert.ToInt32(cmbbxgraduation.SelectedValue.ToString());
            copy.pgid = Convert.ToInt32(cmbbxPG.SelectedValue.ToString());
            copy.enquiryid = Convert.ToInt32(cmbbxEnquirySource.SelectedValue.ToString());
            copy.StudPermanentAddress = rtxtpermanentaddress.Text;
            copy.LocalAddress = rtxtpresentaddress.Text;
            copy.StudPinNo = txtPin.Text;
            copy.StudGender = gender;
            copy.StudEmail = txtemail.Text;

            if (chkbxMorning.Checked)
            {
                copy.StudTimepreffered = chkbxMorning.Text;

            }
            else if (chkbxEvening.Checked)
            {
                copy.StudTimepreffered = chkbxEvening.Text;

            }
            else if (chkbxAfternoon.Checked)
            {
                copy.StudTimepreffered = chkbxAfternoon.Text;

            }

            copy.StudOtherQualification = txtOther.Text;

            if (chkbxFriend.Checked)
            {
                copy.StudReferences = chkbxFriend.Text;

            }
            else if (chkbxPoster.Checked)
            {
                copy.StudReferences = chkbxPoster.Text;

            }
            else if (chkbxSeminar.Checked)
            {
                copy.StudReferences = chkbxSeminar.Text;

            }
            else
            {
                copy.StudReferences = chkbxOther.Text;

            }
            clsConsular cl = new clsConsular(copy);
            cl.Saved();

            MessageBox.Show("SavedSuccessfully");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            frmGridBox f1 = new frmGridBox();
            f1.Show();

        }

    }
}