using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_of_Sale.BL;
using Point_of_Sale.DL;
using System.IO;

namespace Point_of_Sale.DL
{
    class productDL
    {
       public static List<product> products = new List<product>();

       public static int HighestIdx()
        {
            int i, x = 0;
            int highest = products[0].getPrice();
            for (i = 0; i < products.Count; i++)
            {
                if (highest < products[i].getPrice())
                {
                    highest = products[i].getPrice();
                    x = i;
                }
            }
            return x;
        }

        public static void StoreProducts()
        {
             string path = "E:\\Semester 2\\OOP\\week5\\Assignment\\Point_of_Sale\\products.txt";
                StreamWriter f = new StreamWriter(path);
                for (int i = 0; i < products.Count; i++)
                {
                    f.WriteLine("{0},{1},{2},{3},{4},{5}", products[i].getProductname(), products[i].getCategory(), products[i].getPrice(),products[i].getStock(),products[i].getThreshold(),products[i].getSalesTax());
                }
                f.Flush();
                f.Close();
          
        }
        public static void loadProducts()
        {
            string path = "E:\\Semester 2\\OOP\\week5\\Assignment\\Point_of_Sale\\products.txt";
            StreamReader f = new StreamReader(path);
            string record;
            while ((record = f.ReadLine()) != null)
            {
                string[] splittedrecord = record.Split(',');
                string productname = splittedrecord[0];
                string category = splittedrecord[1];
                int price = int.Parse(splittedrecord[2]);
                int stock = int.Parse(splittedrecord[3]);
                int threshold = int.Parse(splittedrecord[4]);
                product p = new product(productname,category,price,stock,threshold);
                products.Add(p);
            }
            f.Close();
        }

        public static int getProductsData(string name)
        {
            for(int i = 0; i < products.Count; i++)
            {
                if(products[i].getProductname() == name)
                {
                    return i;
                }
            }
            return 20;
        }
    }
}
