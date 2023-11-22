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
    public partial class UProduct : Form
    {
        public UProduct()
        {
            InitializeComponent();
        }

        private void grdUProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }

        private void UProduct_Load(object sender, EventArgs e)
        {
            Class1 cl = new Class1();
            DataTable dt = new DataTable();
            dt = cl.UnorderedProduct();
            datagrdProduct.DataSource = dt;

        }
    }
}
