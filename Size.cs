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
    public partial class Size : Form
    {
        public Size()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbbxType.Text))
            {
                errorProvider5.SetError(cmbbxType, "Typename is required");
                return;
            }
            else
            {
                errorProvider5.SetError(cmbbxType, string.Empty);
            }
            if (string.IsNullOrEmpty(cmbbxProduct.Text))
            {
                errorProvider5.SetError(cmbbxProduct, "Product is required");
                return;
            }
            else
            {
                errorProvider5.SetError(cmbbxProduct, string.Empty);
            }
            if (string.IsNullOrEmpty(txtsize.Text))
            {
                errorProvider5.SetError(txtsize, "Size is required");
                return;
            }
            else
            {
                errorProvider5.SetError(txtsize, string.Empty);
            }
            if (string.IsNullOrEmpty(txtRealPrice.Text))
            {
                errorProvider5.SetError(txtRealPrice, "RealPrice is required");
                return;
            }
            else
            {
                errorProvider5.SetError(txtRealPrice, string.Empty);
            }
            if (string.IsNullOrEmpty(txtMRP.Text))
            {
                errorProvider5.SetError(txtMRP, "MRP is required");
                return;
            }
            else
            {
                errorProvider5.SetError(txtMRP, string.Empty);
            }
            int ProductID=Convert.ToInt32(cmbbxProduct.SelectedValue.ToString());
            
            string size = txtsize.Text;
            int MRP = Convert.ToInt32(txtMRP.Text);
            int RPrice = Convert.ToInt32(txtRealPrice.Text);         

           Class1 p = new Class1(ProductID, size,MRP,RPrice);
            p.SaveSize();
            MessageBox.Show("Save Successfully");


        }

        private void Size_Load(object sender, EventArgs e)
        {
            Class1 p = new Class1();
            DataTable dt = new DataTable();
            dt = p.GetAllType();

            cmbbxType.DisplayMember = "TypeName";
            cmbbxType.ValueMember = "TypeID";
            cmbbxType.DataSource = dt;
        }

        private void cmbbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TypeID = Convert.ToInt32(cmbbxType.SelectedValue.ToString());
            Class1 p2 = new Class1(TypeID);
            DataTable dt1 = new DataTable();
            dt1 = p2.GetAllProduct();

            cmbbxProduct.DisplayMember = "ProductName";
            cmbbxProduct.ValueMember =  "ProductID";
            cmbbxProduct.DataSource = dt1;

        }
    }
}
