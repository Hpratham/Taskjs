using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothShop_Project
{
    public partial class OrderProduct : Form
    {
        
        public static string name;
        public static int MRP;
        public static string ProductName;
        public static string userproduct;
        public OrderProduct()
        {
            InitializeComponent();
            

        }
        DataTable dt = new DataTable();


        private void OrderProduct_Load(object sender, EventArgs e)
        {
            // bool Click = true; 
            //string IsDeleted;
            

            //DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
            //col.Width = 30;
            //col.Name = "CheckBox";
            //col.HeaderText = "";
            //dataGridView1.Columns.Insert(0, col);
            //dataGridView1.AllowUserToAddRows = false;

            //if (Click==true)
            //{
            //    IsDeleted = "true";
            //}
            //else
            //{
            //    IsDeleted = "false";
            //}

            Class1 class1 = new Class1();
            dt = class1.Order1();
            dataGridView1.DataSource = dt;





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {  
        }
        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider8.SetError(txtName, "Name is required");
                return;
            }
            else
            {
                errorProvider8.SetError(txtName, string.Empty);
            }
            if (string.IsNullOrEmpty(txtProductName.Text))
            {
                errorProvider8.SetError(txtProductName, "Product Name is required");
                return;
            }
            else
            {
                errorProvider8.SetError(txtProductName, string.Empty);
            }
            MessageBox.Show("Product ready");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
          
            string name = dataGridView1.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
            string value = dataGridView1.Rows[e.RowIndex].Cells["MRP"].Value.ToString();
            string ProductName = dataGridView1.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
            string OrderID= dataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();

            if (dataGridView1.CurrentCell.ColumnIndex==Discount.Index)
            {
                Discount d1 = new Discount(name, value, ProductName, OrderID);
                d1.Show();
            }

            Class1 cs = new Class1(OrderID);
            cs.Delete();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("UserName LIKE '%{0}%'", txtName.Text);
            dataGridView1.DataSource=dv.ToTable();
        }

        private void txtProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("ProductName LIKE '%{0}%'", txtProductName.Text);
            dataGridView1.DataSource = dv.ToTable();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            Class1 cls = new Class1();
            DataTable dt=new DataTable();
            dt = cls.Refresh();
            dataGridView1.DataSource = dt;
            MessageBox.Show("Refresh Succesfully");
            


        }
    }
}
