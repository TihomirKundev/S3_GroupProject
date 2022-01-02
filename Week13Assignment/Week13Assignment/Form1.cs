using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week13Assignment
{
    public partial class Form1 : Form
    {
        Products product = new Products();
        List<Products> transactionLog = new List<Products>();

        
        
        public Form1()
        {
            InitializeComponent();
        }
        private void setData()
        {
           
          
        }
        private void addProduct_Click(object sender, EventArgs e)
        {
         if(!String.IsNullOrEmpty(productName.Text) && !String.IsNullOrEmpty(productPrice.Value.ToString()))
            {
                product.initialiseExpense(productName.Text, Convert.ToDouble(productPrice.Value));
                transactionLog.Add(product);
            }
            else
            {
                MessageBox.Show("Please fill correctly the data");
            }
        }

        private void productListUpdate(object sender, EventArgs e)
        {
            cartList.Items.Clear();
            if(productPriceFilter.Value ==0)
            {
                foreach (var x in transactionLog)
                    cartList.Items.Add(x.getInfo());
            }
            else
            {
                foreach (var x in transactionLog)
                    if(x.getInfo().Contains(productPriceFilter.Value.ToString()))
                    cartList.Items.Add(x.getInfo());
            }
          
        }
    

        private void showAllProducts_Click(object sender, EventArgs e)
        {
            cartList.Items.Clear();
            productPriceFilter.Value = 0;
            foreach (var x in transactionLog)
                cartList.Items.Add(x.getInfo());
        }

        private void filterByprice_Click(object sender, EventArgs e)
        {
      
        }
    }
}
