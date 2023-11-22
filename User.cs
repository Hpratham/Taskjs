using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothShop_Project
{
    public partial class User : Form
    {
        public string Gender;
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            cmbbxType.Items.Add("User");
            cmbbxType.Items.Add("Admin");
            cmbbxState.Items.Add("MP");
            cmbbxState.Items.Add("UP");
            cmbbxState.Items.Add("Rajasthan");
            cmbbxState.Items.Add("Gujrat");
            cmbbxState.Items.Add("Karnataka");

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbbxType.Text))
            {
                errorProvider2.SetError(cmbbxType, "Type is required");
                return;
            }
            else
            {
                errorProvider2.SetError(cmbbxType, string.Empty);
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider2.SetError(txtName, "Username is required");
                return;
            }
            else
            {
                errorProvider2.SetError(txtName, string.Empty);
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider2.SetError(txtPassword, "Username is required");
                return;
            }
            else
            {
                errorProvider2.SetError(txtPassword, string.Empty);
            }
            if (string.IsNullOrEmpty(cmbbxState.Text))
            {
                errorProvider2.SetError(cmbbxState, "State is required");
                return;
            }
            else
            {
                errorProvider2.SetError(cmbbxState, string.Empty);
            }
            if (string.IsNullOrEmpty(rbtnMale.Text))
            {
                errorProvider2.SetError(rbtnMale, "Button CLick is required is required");
                return;
            }
            else
            {
                errorProvider2.SetError(rbtnMale, string.Empty);
            }
            if (string.IsNullOrEmpty(rbtnFemale.Text))
            {
                errorProvider2.SetError(rbtnFemale, "Button CLick is required is required");
                return;
            }
            else
            {
                errorProvider2.SetError(rbtnFemale, string.Empty);
            }

            string Type = cmbbxType.Text;
            string name = txtName.Text;
            int pass = Convert.ToInt32(txtPassword.Text);
            
            string State=cmbbxState.Text;


            //string Gender = "";
            if(rbtnFemale.Checked)
            {
                Gender = rbtnFemale.Text;
            }
           else
            {
                Gender = rbtnMale.Text;
            }
            Class1 c1 = new Class1(Type, name,Gender,pass,State);
            c1.Save();
            MessageBox.Show("Saved Successfully");

        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbbxState.Text = null;
            cmbbxType.Text = null;
            txtName.Text = null;
            txtPassword.Text = null;
            if(rbtnFemale.Checked)
            {
                rbtnFemale.Checked= false;
            }
            else
            { rbtnMale.Checked= false;}
        }
    }
}
