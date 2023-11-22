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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            Class1 cl5 = new Class1();
            DataTable dt = new DataTable();
            dt = cl5.GetAllType();
            cmbbxType.DisplayMember = "TypeName";
            cmbbxType.ValueMember = "TypeID";
            cmbbxType.DataSource = dt;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbbxType.Text))
            {
                errorProvider3.SetError(cmbbxType, "Type is required");
                return;
            }
            else
            {
                errorProvider3.SetError(cmbbxType, string.Empty);
            }
            if (string.IsNullOrEmpty(txtProduct.Text))
            {
                errorProvider3.SetError(txtProduct, "Username is required");
                return;
            }
            else
            {
                errorProvider3.SetError(txtProduct, string.Empty);
            }
            int TypeID = Convert.ToInt32(cmbbxType.SelectedValue.ToString());
            string product = txtProduct.Text;
            Class1 c3 = new Class1(TypeID,product);
            c3.saveproductData();
            MessageBox.Show("Saved Successfully");
        }
    }
}
