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
    public partial class A1cs : Form
    {
        public A1cs()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void A1cs_Load(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();
            DataTable dataTable = new DataTable();  
            dataTable=class1.Fetch();
            dataGridView1.DataSource = dataTable;

           

        }
    }
}
