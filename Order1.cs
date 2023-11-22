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

namespace ClothShop_Project
{
    public partial class Order1 : Form
    {
       
        public Order1()
        {
            InitializeComponent();
        }

        private void Order1_Load(object sender, EventArgs e)
        {
            
            Class1 p = new Class1();
            DataTable dt2 = new DataTable();
            dt2 = p.GetAllType();
            cmbbxType.DisplayMember = "TypeName";
            cmbbxType.ValueMember = "TypeID";
            cmbbxType.DataSource = dt2;

            lbl1.Text = Login.Name1;
         //   lbl3.Text = Login.Password;

            lstView.Columns.Add("Type", 120);
            lstView.Columns.Add("Product", 120);
            lstView.Columns.Add("Size", 120);
            lstView.Columns.Add("Price", 120);


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
            grdOrderData12.DataSource = dt;
            grdOrderData12.Show();
        }
        private void grdOrderData12_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }



        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            
            String Type = cmbbxType.Text;
            String Product=cmbbxProduct.Text;
            int RowIndex = grdOrderData12.CurrentCell.RowIndex;
            String Size=grdOrderData12.Rows[RowIndex].Cells[0].Value.ToString();
            string Price = txtPrice.Text;
            ListViewItem cl = new ListViewItem();
            lstView.Columns.Add(Type);
            lstView.Columns.Add(Product);
            lstView.Columns.Add(Size);
            lstView.Columns.Add(Price);
            lstView.Items.Add(cl);
           



        }

        
        private void grdOrderData12_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int RowIndex = grdOrderData12.CurrentCell.RowIndex;
            int SizeID = Convert.ToInt32(grdOrderData12.Rows[RowIndex].Cells[0].Value.ToString());
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
            cmbbxProduct.Text = null;
            cmbbxType.Text = null;
            txtPrice.Text= null;
        }

        private void Order1_Click(object sender, EventArgs e)
        {
            int RowIndex = grdOrderData12.CurrentCell.RowIndex;
            int SizeID = Convert.ToInt32(grdOrderData12.Rows[RowIndex].Cells[0].Value.ToString());
            Class1 cl3 = new Class1(SizeID);
            SqlDataReader dr;
            dr = cl3.Price();
            while (dr.Read())
            {
                txtPrice.Text = dr["MRP"].ToString();

            }
            dr.Close();
        }
    }
}
   