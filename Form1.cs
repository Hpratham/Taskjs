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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            user.MdiParent = this;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            login.MdiParent = this;
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type type = new Type();
            type.Show();
            type.MdiParent = this;
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Show();
            product.MdiParent = this;
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size size = new Size();
            size.Show();
            size.MdiParent = this;
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order2 order = new Order2();
            order.Show();
            order.MdiParent = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
