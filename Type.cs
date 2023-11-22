using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ClothShop_Project
{
    public partial class Type : Form
    {
        public Type()
        {
            InitializeComponent();
        }

        private void Type_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtType.Text))
            {
                errorProvider6.SetError(txtType, "Username is required");
                return;
            }
            else
            {
                errorProvider6.SetError(txtType, string.Empty);
            }
            Class1 cl6 = new Class1(txtType.Text);
            cl6.SaveType();
            MessageBox.Show("Add Successfully");

        }
    }
}
