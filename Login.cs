using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ClothShop_Project
{
    public partial class Login : Form
    {
        public static string Name1;
        public static int Password;
       


        public string UserType;
            public string UserName;
            public int UserPass;
        public int UserID;
        public Login()
        {
       
        InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            cmbbxType1.Items.Add("Admin");
            cmbbxType1.Items.Add("User");
            
           
            

                
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            cmbbxType1.Text = null;
            txtUserName.Text = null;
            txtPassword.Text= null;

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {



            if (string.IsNullOrEmpty(cmbbxType1.Text))
            {
                errorProvider1.SetError(cmbbxType1, "Username is required");
                return;
            }
            else
            {
                errorProvider1.SetError(cmbbxType1, string.Empty);
            }
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "Username is required");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName,string.Empty);
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Userpassword is required");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, string.Empty);
            }

            string UType = cmbbxType1.Text;
            string UName = txtUserName.Text;
            int UserPassword = Convert.ToInt32(txtPassword.Text);
            Class1 cl3 = new Class1(UType, UName,UserPassword, UserID);
            SqlDataReader dr;
            dr = cl3.Login();
           while(dr.Read()) 
            {
                UserType = dr["UserType"].ToString();
                UserName = dr["UserName"].ToString();
                UserPass= Convert.ToInt32(dr["UserPassword"].ToString());
                UserID = Convert.ToInt32(dr["UID"].ToString());
               
            }
           
           if (UserType=="User"&& UserName==UName && UserPass== UserPassword)
            {
                MessageBox.Show("Login Successfull");
                Order2 or = new Order2();
                or.Show();

            }
            else if(UserType=="Admin" && UserName==UName && UserPass== UserPassword)
            {

                MessageBox.Show("Successfull Login");
                Admin1 or = new Admin1();
                or.Show();
                
            }
            if (UserType == "User" && UserName == UName && UserPass == UserPassword)
            {

                string Name1 = txtUserName.Text;
                string Password = txtPassword.Text;



            }









        }

        private void cmbbxType1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        //    private void txtUserName_Leave(object sender, EventArgs e)
        //    {
        //        if (string.IsNullOrEmpty(txtUserName.Text) == true)
        //        {
        //            txtUserName.Focus();
        //            MessageBox.Show("Fill the Name");
        //        }
        //        else
        //        {

        //        }
        //    }

        //    private void txtPassword_Leave(object sender, EventArgs e)
        //    {
        //        if (string.IsNullOrEmpty(txtPassword.Text) == true)
        //        {
        //            txtPassword.Focus();
        //            MessageBox.Show("Fill the Password");
        //        }
        //        else
        //        {

        //        }
        //    }
    }


}

