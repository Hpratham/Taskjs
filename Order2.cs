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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Data;
using Microsoft.SqlServer.Server;
using System.Security.Cryptography;

namespace ClothShop_Project
{
    
    public partial class Order2 : Form
    {
        private string name1;
        private int password;

        public int UserID { get; set; }
        public string SizeID { get; set; }
        public string Name1 { get; set; }
        public string Password { get; set; }
        
        public Order2(string Name, string Password, int UID)
        {
            InitializeComponent();
            lbl3.Text = Name1;
            lbl4.Text = Password;
            //lbluid1.Text =Convert.ToString(UID);
            UserID = UID;

        }
        public Order2()
        {
            InitializeComponent();

        }

        public Order2(string name1, int password)
        {
            this.name1 = name1;
            this.password = password;
        }

        private void Order2_Load(object sender, EventArgs e)
        {
            Class1 p = new Class1();
            DataTable dt2 = new DataTable();
            dt2 = p.GetAllType();
            cmbbxType.DisplayMember = "TypeName";
            cmbbxType.ValueMember = "TypeID";
            cmbbxType.DataSource = dt2;


            //lstv1.Columns.Add("Type", 100);
            //lstv1.Columns.Add("Product", 100);
            //lstv1.Columns.Add("Size", 100);
            //lstv1.Columns.Add("Price", 100);
            //lstv1.Columns.Add("SizeID", 100);

        }

        private void cmbbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TypeID = Convert.ToInt32(cmbbxType.SelectedValue.ToString());
            Class1 p2 = new Class1(TypeID);
            DataTable dt1 = new DataTable();
            dt1 = p2.GetAllProduct();
            cmbbxProduct.DisplayMember = "ProductName";
            cmbbxProduct.ValueMember = "ProductID";
            cmbbxProduct.DataSource = dt1;
        }

        private void cmbbxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ProductID = Convert.ToInt32(cmbbxProduct.SelectedValue.ToString());
            Class1 cl3 = new Class1(ProductID);
            DataTable dt = new DataTable();
            dt = cl3.Order();
            grdOrder1.DataSource = dt;
            grdOrder1.Show();
        }

        private void grdOrder1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = grdOrder1.CurrentCell.RowIndex;
            int SizeID = Convert.ToInt32(grdOrder1.Rows[RowIndex].Cells[0].Value.ToString());
            Class1 cl3 = new Class1(SizeID);
            SqlDataReader dr;
            dr = cl3.Price();
            while (dr.Read())
            {
                txtPrice.Text = dr["MRP"].ToString();

            }
            dr.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbbxProduct.Text = "";
            cmbbxType.Text = "";
            txtPrice.Text = "";
            grdOrder1.Columns.Clear();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            String Type = cmbbxType.Text;
            String Product = cmbbxProduct.Text;
            int RowIndex = grdOrder1.CurrentCell.RowIndex;
            String Size = grdOrder1.Rows[RowIndex].Cells[1].Value.ToString();
            string Price = txtPrice.Text;
           


            //  String SizeID = grdOrder1.Rows[RowIndex].Cells[0].Value.ToString();





        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(grdOrder1.Text))
            {
                errorProvider0.SetError(grdOrder1, "Enter the correct options");
            }
            else
            {
                errorProvider0.SetError(grdOrder1, "Please provide the correct options");
            }
            String Type = cmbbxType.Text;
            String Product = cmbbxProduct.Text;
            int RowIndex = grdOrder1.CurrentCell.RowIndex;
            String Size = grdOrder1.Rows[RowIndex].Cells[1].Value.ToString();
            String SizeID = grdOrder1.Rows[RowIndex].Cells[0].Value.ToString();
            string Price = txtPrice.Text;
           



            ListViewItem AC = new ListViewItem(Type);
            AC.SubItems.Add(Product);
            AC.SubItems.Add(Size);
            AC.SubItems.Add(Price);
            AC.SubItems.Add(SizeID);
            lstv1.Items.Add(AC);

            
        }
        private void btnTotal_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < lstv1.Items.Count; i++)
            {
                if (lstv1.Items[i].SubItems.Count > 0)
                {
                    sum += int.Parse(lstv1.Items[i].SubItems[3].Text);
                }
                txtTotal.Text = sum.ToString();

            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstv1.Items.Count; i++)
            {
                int Sizeid = int.Parse(lstv1.Items[i].SubItems[4].Text);
                string status = "Confirm";
                string date = DateTime.UtcNow.ToString("dd-MM-yyyy");

                Class1 obj = new Class1(Sizeid,UserID,status,date);
                obj.OData();
                MessageBox.Show("Saved Successfull");
            }
           



        }




        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {

            lstv1.Columns.Clear();  

        }

        private void grdOrder1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbbxProduct_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbbxProduct.Text))
            {
                MessageBox.Show("please enter the product");
            }
           
        }

        private void cmbbxType_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbbxType.Text))
            {
                MessageBox.Show("Enter the Type");
            }
        }

        private void e(object sender, EventArgs e)
        {

        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Enter the Price");
            }
        }

        private void grdOrder1_Validating(object sender, CancelEventArgs e)
        {
            
        }
    }
}

