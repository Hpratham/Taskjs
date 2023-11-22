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
    
    public partial class UCustomer : Form
    {
       
       
        public UCustomer()
        {
            InitializeComponent();
          
         

        }

        

        private void UCustomer_Load(object sender, EventArgs e)
        {
            Class1 customer = new Class1();
            DataTable dt = new DataTable();
            dt = customer.UnorderedCustomer();
            grdUCustomer.DataSource = dt;
        }

        private void grdUCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
