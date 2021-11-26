using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13Assignment
{
    class Products
    {
        private string productName="";
        private double productPrice = 0;

        public void initialiseExpense(string productName,double productPrice)
        {
            this.productName = productName;
            this.productPrice = productPrice;
        }
       
        public string getInfo()
        {
            return productName + " - " + productPrice;
        }
    }
}
