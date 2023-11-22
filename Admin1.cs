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
    public partial class Admin1 : Form
    {
        public Admin1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void Admin1_Load(object sender, EventArgs e)
        {

        }

        private void allProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A1cs q= new A1cs();
            q.Show();
            q.MdiParent = this;
        }

        private void orderProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderProduct product = new OrderProduct();
            product.Show();
            product.MdiParent = this;

        }

        private void unorderedCutomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCustomer u1 = new UCustomer();
            u1.Show();
           
        }

        private void unorderedProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UProduct u2 = new UProduct();
            u2.Show();
            u2.MdiParent = this;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
