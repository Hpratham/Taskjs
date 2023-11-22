using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothShop_Project
{
    public partial class Order : Form
    {
        
        public Order()

        {

            InitializeComponent();
            
        }

        private void Order_Load(object sender, EventArgs e)
        {
            Class1 p = new Class1();
            DataTable dt2 = new DataTable();
            dt2 = p.GetAllType();


           


            cmbbxType.DisplayMember = "TypeName";
            cmbbxType.ValueMember = "TypeID";
            cmbbxType.DataSource = dt2;




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
            int ProductID = Convert.ToInt32(cmbbxType.SelectedValue.ToString());
            Class1 cl1 = new Class1(ProductID);
            DataTable dt3 = new DataTable();
            dt3 = cl1.Order();
            grdOrderData.DataSource = dt3;
            grdOrderData.Show();


            
            


        }
        private void cmbbxType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int TypeID = Convert.ToInt32(cmbbxType.SelectedValue.ToString());
            Class1 p2 = new Class1(TypeID);
            DataTable dt1 = new DataTable();

            dt1 = p2.GetAllProduct();

            cmbbxProduct.DisplayMember = "ProductName";
            cmbbxProduct.ValueMember = "ProductID";
            cmbbxProduct.DataSource = dt1;
        }

        private void grdOrderData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void grdOrderData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbbxType= null;
            cmbbxProduct= null;
            txtPrice.Text=null;
            MessageBox.Show("Clear Successfull");
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Class1 cl3 = new Class1();
            this.Close();


        }

        private void grdOrderData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = grdOrderData.CurrentCell.RowIndex;
            int SizeID = Convert.ToInt32(grdOrderData.Rows[RowIndex].Cells[0].Value.ToString());



            Class1 cl3 = new Class1(SizeID);
            SqlDataReader dr;
            dr = cl3.Price();
            while (dr.Read())
            {
                txtPrice.Text = dr["MRP"].ToString();
                 
            }
            dr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          


        }
    }
}
