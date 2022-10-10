using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sale.BL
{
    class product
    {
        private string productname;
        private string category;
        private int price;
        private int stock;
        private int threshold;
        private int SalesTax;

        public product()
        {

        }

        public product(string productname,string category,int price,int stock,int threshold)
        {
            this.productname = productname;
            this.category = category;
            this.price = price;
            this.stock = stock;
            this.threshold = threshold;
            if(category == "grocery")
            {
                this.SalesTax = 10;
            }
            if(category == "fruit")
            {
                this.SalesTax = 5;
            }
            if(category == "other")
            {
                this.SalesTax = 15;
            }
        }

        public string getProductname()
        {
            return productname;
        }

        public string getCategory()
        {
            return category;
        }

        public int getPrice()
        {
            return price;
        }

        public int getStock()
        {
            return stock;
        }

        public int getThreshold()
        {
            return threshold;
        } 

        public int getSalesTax()
        {
            return SalesTax;
        }

        public void setproductname(string productname)
        {
            this.productname = productname;
        }

        public void setCategory(string category)
        {
            this.category = category;
        }

        public void setPrice(int price)
        {
            this.price = price;
        }

        public void setStock(int stock)
        {
            this.stock = stock;
        }

        public void setThreshold(int threshold)
        {
            this.threshold = threshold;
        }

        public void setSalesTax(int salesTax)
        {
            this.SalesTax = salesTax;
        }

        
    }
}
