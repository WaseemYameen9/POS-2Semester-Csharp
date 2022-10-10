using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sale.BL
{
    class customer
    {
        private List<product> cproducts = new List<product>();
        private double bill;


        public customer()
        {

        }

        public double getBill()
        {
            return bill;
        } 

        public void setBill(double bill)
        {
            this.bill = bill;
        }

        public List<product> getCproducts()
        {
            return cproducts;
        }
    }
}
