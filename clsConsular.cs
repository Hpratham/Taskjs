using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace CRM1
{
    internal class clsConsular
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-11G9KID6\\SQLEXPRESS;Initial Catalog=GSTCRM;Integrated Security=True");


        public string StudCode { get; set; }    
        public string StudFullName { get; set; }    
        public string StudContactNo { get; set; }
        public string StudAlternateNo { get; set; } 
        public string StudEmail { get;set; }    
        public string StudGender { get;set; }   
        public string LocalAddress { get; set; }    
        public string StudPermanentAddress { get; set; }   
        public string StudTimepreffered { get; set; }
        public string StudPinNo { get; set; }       
        public string StudOtherQualification { get; set; }
        public string StudProfessionalStatus { get;set; }   
        public string StudReferences { get; set; }  
        public string Country { get; set; } 
        public int CountryId { get; set; }
        public DateTime EnquiryDate { get; set; }
        public DateTime StudDob { get; set; }

        public string EducationalStatus { get; set; }
        public string city { get;set; }
        public int CityId { get; set; }
        public string Graduation { get; set; }
        public int graduationid { get; set; }
        public int pgid { get; set; }
         public string pg { get; set; } 
        public int enquiryid { get; set; }  
        public string Enquiry { get;set; }
        public int Stateid { get; set; }
        public string CourseInterested { get;  set; }

        public clsConsular(clsConsular original)
        {
            StudCode = original.StudCode;
            StudFullName = original.StudFullName;
            StudContactNo = original.StudContactNo;
            StudAlternateNo = original.StudAlternateNo;
            StudEmail = original.StudEmail;
            StudGender = original.StudGender;
            LocalAddress = original.LocalAddress;
            StudPermanentAddress = original.StudPermanentAddress;
            StudPinNo = original.StudPinNo;
            StudOtherQualification = original.StudOtherQualification;
            StudProfessionalStatus = original.StudProfessionalStatus;
            StudReferences = original.StudReferences;
            CountryId = original.CountryId;
            city = original.city;
            EnquiryDate = original.EnquiryDate;
            CityId = original.CityId;
            Graduation = original.Graduation;
            graduationid = original.graduationid;
            pg = original.pg;
            pgid = original.pgid;
            Enquiry = original.Enquiry;
            enquiryid = original.enquiryid;
            Stateid = original.Stateid;
            StudTimepreffered= original.StudTimepreffered;
            CourseInterested = original.CourseInterested;
        }

    
   
        public clsConsular() { }

        public void Saved()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("counsolar", con);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "Select");
            cmd.Parameters.AddWithValue("@StudCode",StudCode);
            cmd.Parameters.AddWithValue("@StudFullName",StudFullName);
            cmd.Parameters.AddWithValue("@StudContactNo",StudContactNo );
            cmd.Parameters.AddWithValue("@StudAlternateNo", StudAlternateNo);
            cmd.Parameters.AddWithValue("@StudEmail",StudEmail );
            cmd.Parameters.AddWithValue("@StudGender",StudGender );
            cmd.Parameters.AddWithValue("@StudLocalAddress",LocalAddress);
            cmd.Parameters.AddWithValue("@StudPermanentAddress",StudPermanentAddress );
            cmd.Parameters.AddWithValue("@StudCityId", CityId);
            cmd.Parameters.AddWithValue("@StudEnquiryDate", EnquiryDate);

            cmd.Parameters.AddWithValue("@StudPinNo",StudPinNo ); 
            cmd.Parameters.AddWithValue("@GradId",graduationid );
            cmd.Parameters.AddWithValue("@PGId",pgid );
            cmd.Parameters.AddWithValue("@StudProfessionalStatus",StudProfessionalStatus );
            cmd.Parameters.AddWithValue("@StudReferences",StudReferences );
            cmd.Parameters.AddWithValue("@StudOtherQualification",StudOtherQualification );
            cmd.Parameters.AddWithValue("@EnquirySourceId",enquiryid );
            cmd.Parameters.AddWithValue("@StudTimePreferred", StudTimepreffered);
            cmd.Parameters.AddWithValue("@CourseInterested", CourseInterested);

            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Update()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("counsolar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "Update");
            cmd.Parameters.AddWithValue("@StudCode", StudCode);
            cmd.Parameters.AddWithValue("@StudFullName", StudFullName);
            cmd.Parameters.AddWithValue("@StudContactNo", StudContactNo);
            cmd.Parameters.AddWithValue("@StudAlternateNo", StudAlternateNo);
            cmd.Parameters.AddWithValue("@StudEmail", StudEmail);
            cmd.Parameters.AddWithValue("@StudGender", StudGender);
            cmd.Parameters.AddWithValue("@StudLocalAddress", LocalAddress);
            cmd.Parameters.AddWithValue("@StudPermanentAddress", StudPermanentAddress);
            cmd.Parameters.AddWithValue("@StudCityId", CityId);
            cmd.Parameters.AddWithValue("@StudEnquiryDate", EnquiryDate);
            cmd.Parameters.AddWithValue("@StudPinNo", StudPinNo);
            cmd.Parameters.AddWithValue("@GradId", graduationid);
            cmd.Parameters.AddWithValue("@PGId", pgid);
            cmd.Parameters.AddWithValue("@StudProfessionalStatus", StudProfessionalStatus);
            cmd.Parameters.AddWithValue("@StudReferences", StudReferences);
            cmd.Parameters.AddWithValue("@StudOtherQualification", StudOtherQualification);
            cmd.Parameters.AddWithValue("@EnquirySourceId", enquiryid);
            cmd.Parameters.AddWithValue("@StudTimePreferred", StudTimepreffered);
            cmd.Parameters.AddWithValue("@CourseInterested", CourseInterested);

            cmd.ExecuteNonQuery();
            con.Close();

        }

        public DataTable GetStud()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("counsolar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "insert");
            // cmd.Parameters.AddWithValue("",);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable GetCountry()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("counsolar",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetCountry");
           // cmd.Parameters.AddWithValue("",);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable GetState()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("counsolar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetState");
             cmd.Parameters.AddWithValue("@CountryId", CountryId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable GetCity()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("counsolar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetCity");
            cmd.Parameters.AddWithValue("@StateId",Stateid);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }

        public DataTable Getgraduation()
        {
            con.Close();
            
            con.Open();
            SqlCommand cmd = new SqlCommand("counsolar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetGraduation");
            SqlDataAdapter adpt3 = new SqlDataAdapter();
            adpt3.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt3.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable GetPG()
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("counsolar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetPG");
            SqlDataAdapter adpt2 = new SqlDataAdapter();
            adpt2.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt2.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable GetEnquiry()
        {
            con.Close();
            
            con.Open();
            SqlCommand cmd = new SqlCommand("counsolar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetEnquiry");

            SqlDataAdapter adpt4 = new SqlDataAdapter();
            adpt4.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt4.Fill(dt);
            return dt;
            con.Close();
        }
       
        public DataTable GridBox()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("counsolar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "Grid");
            SqlDataAdapter adpt4 = new SqlDataAdapter();
            adpt4.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt4.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable Course()
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("counsolar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "Courses");
            SqlDataAdapter adpt4 = new SqlDataAdapter();
            adpt4.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt4.Fill(dt);
            return dt;
            con.Close();
        }
        public SqlDataReader Editfetch()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("counsolar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "Editfetch");
            cmd.Parameters.AddWithValue("@StudCode", StudCode);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }
    }

}



