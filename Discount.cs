using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ClothShop_Project
{
    public partial class Discount : Form
    {
        public string OrderId { get; private set; }

        //public int MRP { get; set; }
        //public string name{get;set;}


        public Discount(string name,string value,string ProductName,string OrderID)
        {
            
            InitializeComponent();
            lblOldPrice.Text = value;
            lblname1.Text = name;
            lblProductName.Text = ProductName;
            lblOrder.Text = OrderID;

            

        }

        

        private void grpOfferInformation_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnCalculatedNewPrice_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiscount.Text))
            {
                errorProvider7.SetError(txtDiscount, "Discount is required");
                return;
            }
            else
            {
                errorProvider7.SetError(txtDiscount, string.Empty);
            }
            double Percentage = Convert.ToDouble(txtDiscount.Text);
            double OriginalPrice= Convert.ToDouble(lblOldPrice.Text);
            Percentage /= 100;
            double per = OriginalPrice * Percentage;
            double newprice= OriginalPrice - per;
            txtNewPrice.Text = newprice.ToString();

        }

        private void btnUpdatedPrice_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPrice.Text))
            {
                errorProvider7.SetError(txtNewPrice, "Username is required");
                return;
            }
            else
            {
                errorProvider7.SetError(txtNewPrice, string.Empty);
            }
            string Discount= txtDiscount.Text;
           string orderID=(lblOrder.Text);
            int NewPrice = int.Parse(txtNewPrice.Text);
                Class1 cl1 = new Class1(orderID, Discount,NewPrice);
            cl1.UpdatenewPrice();
            MessageBox.Show("Price Saved Successfully");
        }
    }
}
