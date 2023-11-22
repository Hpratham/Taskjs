using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.AxHost;

namespace CRM1
{
    public partial class frmEdit : Form
    {
        private string enquirysource { get; set; }
        public string gender;
        public string EducationStatus;
        public string ProfessionalStatus;
        public string Reference;
        public string CourseInterested1 = "";

        public string Timepreffer { get;  set; }

        public string StudCode = "";

        DataTable dt = new DataTable();

        public string city { get;  set; }
        public string state { get;  set; }
        public string country { get;  set; }
        public string pgname { get;  set; }
        public string grad { get;  set; }
        public string status { get;  set; }

        public frmEdit(string studCode)
        {
            InitializeComponent();
           
            StudCode = studCode;
            
        }

        private void chkbxMorning_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void display()
        {
            clsConsular cl = new clsConsular();
            cl.StudCode = StudCode;
            clsConsular p4 = new clsConsular(cl);
            SqlDataReader dr;
            dr = p4.Editfetch();
            while(dr.Read())
            {
                lblfullname.Text = dr["StudFullName"].ToString();
                txtmobileno.Text = dr["StudContactNo"].ToString();
                txtAlternateno.Text = dr["StudAlternateNo"].ToString();
                rtxtpresentaddress.Text = dr["StudLocalAddress"].ToString();
                txtemailid.Text = dr["StudEmail"].ToString();
                rtxtpermenantaddress.Text = dr["StudPermanentAddress"].ToString();
                txtPin.Text = dr["StudPinNo"].ToString();
                txtOther.Text = dr["StudOtherQualification"].ToString();
                city= dr["CityName"].ToString();
                state = dr["StateName"].ToString();
                country = dr["CountryName"].ToString();
                pgname = dr["PGName"].ToString();
                grad= dr["GradName"].ToString();
                status= dr["Status"].ToString();
                CourseInterested1 = dr["CourseInterested"].ToString();
                Timepreffer = dr["StudTimePreferred"].ToString();
                Reference = dr["StudReferences"].ToString();
                dtp.Value =Convert.ToDateTime( dr["StudEnquiryDate"].ToString());
                enquirysource = dr["EnquirySourceName"].ToString();
                gender = dr["StudGender"].ToString(); 
                ProfessionalStatus = dr["StudProfessionalStatus"].ToString();

            }
            if(rdbtnMale.Text==gender)
            {
                rdbtnMale.Checked = true;
            }
            else
            {
                rdbtnFemale.Checked = true;

            }

            if (rdbtnEmployed.Text == ProfessionalStatus)
            {
                rdbtnEmployed.Checked = true;
            }
            else if(rdbtnnonEmployed.Text == ProfessionalStatus)
            {
                rdbtnnonEmployed.Checked = true;

            }
            else
            {
                rdbtnStudent.Checked = true;

            }

            if (chkbxAfternoon.Text == Timepreffer)
            {
                chkbxAfternoon.Checked = true;
            }
            else if(chkbxEvenning.Text == Timepreffer)
            {
                chkbxEvenning.Checked = true;

            }
            else
            {
                chkbxMorning.Checked = true;

            }

            if (chkbxPoster.Text == Reference)
            {
                chkbxPoster.Checked = true;
            }
            else if (chkbxOther.Text == Timepreffer)
            {
                chkbxOther.Checked = true;

            }
            else if (chkbxSeminar.Text == Timepreffer)
            {
                chkbxSeminar.Checked = true;

            }
            else
            {
                chkbxfriendreference.Checked = true;

            }

        }
        private void frmEdit_Load(object sender, EventArgs e)
        {
            clsConsular cl = new clsConsular();
            display();

            dt = cl.GetCountry();
            cmbbxCountry.DisplayMember = "CountryName";
            cmbbxCountry.ValueMember = "CountryId";
            cmbbxCountry.DataSource = dt;
            cmbbxCountry.Text = country;

            clsConsular p4 = new clsConsular();
            DataTable dt1 = new DataTable();
            DataTable dt2= new DataTable();
            DataTable dt3 = new DataTable();
           
            dt1 = cl.Getgraduation();
            cmbbxgraduation.DisplayMember = "GradName";
            cmbbxgraduation.ValueMember = "GradId";
            cmbbxgraduation.DataSource = dt1;
            cmbbxgraduation.Text = grad;

            clsConsular p5 = new clsConsular();
           
            dt2 = cl.GetPG();
            cmbbxPG.DisplayMember = "PGName";
            cmbbxPG.ValueMember = "PGId";
            cmbbxPG.DataSource = dt2;
            cmbbxPG.Text = pgname;

            clsConsular p6 = new clsConsular();
           
            dt3= cl.GetEnquiry();
            cmbbxEnquirySource.DisplayMember = "EnquirySourceName";
            cmbbxEnquirySource.ValueMember = "EnquirySourceId";
            cmbbxEnquirySource.DataSource = dt3;
            cmbbxEnquirySource.Text = enquirysource;

            DataTable grid = new DataTable();
            grid = p6.Course();
            grdCourse1.DataSource = grid;
            grdCourse1.Columns["CourseId"].Visible = false;


        }

        private void cmbbxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsConsular obj5 = new clsConsular();
            int CountryId = Convert.ToInt32(cmbbxCountry.SelectedValue);
            obj5.CountryId = CountryId;

            dt = obj5.GetState();
            cmbbxState.DisplayMember = "StateName";
            cmbbxState.ValueMember = "StateId";
            cmbbxState.DataSource = dt;
            cmbbxState.Text = state;

        }

        private void cmbbxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsConsular obj6= new clsConsular();
            int Stateid = Convert.ToInt32(cmbbxState.SelectedValue);
            obj6.Stateid =Stateid;

            dt = obj6.GetCity();
            cmbbxCity.DisplayMember = "CityName";
            cmbbxCity.ValueMember = "CityId";
            cmbbxCity.DataSource = dt;
            cmbbxCity.Text = city;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            clsConsular copy = new clsConsular();
            copy.StudCode = StudCode;
            copy.StudFullName = lblfullname.Text;
            copy.StudContactNo = txtmobileno.Text;
            copy.StudAlternateNo = txtAlternateno.Text;
            copy.StudEmail = txtemailid.Text;
            copy.StudGender = gender;
            copy.StudPermanentAddress = rtxtpermenantaddress.Text;
          

            string[] CourseInterested = { };
            string education = "";
            foreach (DataGridViewRow dr in grdCourse1.Rows)
            {
                if (dr.Cells[0].Value != null)
                {
                    if ((bool)dr.Cells[0].Value == true)
                    {
                        int row = dr.Cells[0].RowIndex;
                        CourseInterested = CourseInterested.Append(grdCourse1.Rows[row].Cells["CourseId"].Value.ToString()).ToArray();
                    }
                }
            }
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
            else if (rdbtnnonEmployed.Checked)
            {
                copy.StudProfessionalStatus = rdbtnnonEmployed.Text;

            }
            else
            {
                copy.StudProfessionalStatus = rdbtnStudent.Text;

            }
            copy.EnquiryDate = dtp.Value;
            education = string.Join(",", CourseInterested);
            copy.CourseInterested = education;
            copy.CityId = Convert.ToInt32(cmbbxCity.SelectedValue.ToString());
            copy.graduationid = Convert.ToInt32(cmbbxgraduation.SelectedValue.ToString());
            copy.pgid = Convert.ToInt32(cmbbxPG.SelectedValue.ToString());
            copy.enquiryid = Convert.ToInt32(cmbbxEnquirySource.SelectedValue.ToString());
            copy.StudPermanentAddress = rtxtpermenantaddress.Text;
            copy.StudPinNo = txtPin.Text;
            copy.StudGender = gender;
            copy.StudEmail = txtemailid.Text;

            if (chkbxMorning.Checked)
            {
                copy.StudTimepreffered = chkbxMorning.Text;

            }
            else if (chkbxEvenning.Checked)
            {
                copy.StudTimepreffered = chkbxEvenning.Text;

            }
            else if (chkbxAfternoon.Checked)
            {
                copy.StudTimepreffered = chkbxAfternoon.Text;

            }

            copy.StudOtherQualification = txtOther.Text;

            if (chkbxfriendreference.Checked)
            {
                copy.StudReferences = chkbxfriendreference.Text;

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
            if(string.IsNullOrEmpty(txtAlternateno.Text))
            {
                errorProvider2.SetError(txtAlternateno, "Alternate no is required");
            }
            else
            {
                errorProvider2.SetError(txtAlternateno,string.Empty);
            }
            if (string.IsNullOrEmpty(txtemailid.Text))
            {
                errorProvider2.SetError(txtemailid, "Alternate no is required");
            }
            else
            {
                errorProvider2.SetError(txtemailid, string.Empty);
            }
            if (string.IsNullOrEmpty(txtmobileno.Text))
            {
                errorProvider2.SetError(txtmobileno, "mobileno is required");
            }
            else
            {
                errorProvider2.SetError(txtmobileno, string.Empty);
            }
            if (string.IsNullOrEmpty(txtOther.Text))
            {
                errorProvider2.SetError(txtOther, "Other is required");
            }
            else
            {
                errorProvider2.SetError(txtOther, string.Empty);
            }
            if (string.IsNullOrEmpty(txtPin.Text))
            {
                errorProvider2.SetError(txtPin, "Pin is required");
            }
            else
            {
                errorProvider2.SetError(txtPin, string.Empty);
            }
            if (string.IsNullOrEmpty(rtxtpermenantaddress.Text))
            {
                errorProvider2.SetError(rtxtpermenantaddress, "permenantaddress is required");
            }
            else
            {
                errorProvider2.SetError(rtxtpermenantaddress, string.Empty);
            }
            if (string.IsNullOrEmpty(rtxtpresentaddress.Text))
            {
                errorProvider2.SetError(rtxtpresentaddress, "presentaddress is required");
            }
            else
            {
                errorProvider2.SetError(rtxtpresentaddress, string.Empty);
            }
           

            clsConsular original = new clsConsular(copy);

            original.Update();
            MessageBox.Show("UpdateSuccessfully");
           
        }
    }
    
    
}

