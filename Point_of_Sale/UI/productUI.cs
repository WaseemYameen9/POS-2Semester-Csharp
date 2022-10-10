using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_of_Sale.BL;
using Point_of_Sale.DL;
using Point_of_Sale.UI;

namespace Point_of_Sale.UI
{
    class productUI
    {
       public  static product InputProduct()
        {
            Console.Clear();
            Console.WriteLine(" >> SUB MENU :");
            Console.WriteLine("_______________________");
            Console.Write("Enter Product name :");
            string productname = Console.ReadLine();
            Console.Write("Enter product category :");
            string category = Console.ReadLine();
            Console.Write("Enter it's Price :");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Enter it's available stock :");
            int stock = int.Parse(Console.ReadLine());
            Console.Write("Enter its Minimum Threshold Quantity :");
            int threshold = int.Parse(Console.ReadLine());
            product prod = new product(productname, category, price, stock, threshold);
            return prod;
        }

       public static void ViewProducts()
        {
            Console.Clear();
            Console.WriteLine("_______________ALL PRODUCTS_______________");
            Console.WriteLine("__________________________________________");
            Console.WriteLine("NAME \t\t CATEGORY \t\t PRICE \t\t STOCK \t\t MINIMUM THRESHOLD");
            for (int i = 0; i < productDL.products.Count; i++)
            {
                Console.WriteLine("{0} \t\t   {1} \t\t {2} \t\t {3} \t\t {4}", productDL.products[i].getProductname(), productDL.products[i].getCategory(), productDL.products[i].getPrice(), productDL.products[i].getStock(), productDL.products[i].getThreshold());
            }
            Console.ReadKey();
        }

        public static void HighestPrice()
        {
            int i = 0;
            Console.Clear();
             i = productDL.HighestIdx();
            Console.WriteLine("____________PRODUCT WITH HIGHEST PRICE______________");
            Console.WriteLine("____________________________________________________");
            Console.WriteLine("NAME \t\t CATEGORY \t\t PRICE \t\t STOCK");
            Console.WriteLine("{0} \t\t {1} \t\t   {2} \t\t {3}", productDL.products[i].getProductname(), productDL.products[i].getCategory(), productDL.products[i].getPrice(), productDL.products[i].getStock());
            Console.ReadKey();
        }

       public static void ViewSalesTax()
        {
            Console.Clear();
            Console.WriteLine("________________SALES TAX ON ALL PRODUCTS_____________________");
            Console.WriteLine("______________________________________________________________");
            Console.WriteLine("NAME \t\t CATEGORY \t\t SALES TAX");
            for (int i = 0; i < productDL.products.Count; i++)
            {
                Console.WriteLine("{0} \t\t {1} \t\t {2}", productDL.products[i].getProductname(), productDL.products[i].getCategory(), productDL.products[i].getSalesTax());
            }
            Console.ReadKey();
        }

       public static void ThresholdProducts()
        {
            Console.Clear();
            Console.WriteLine("_____________PRODUCTS TO BE ORDERED______________");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine("NAME \t\t STOCK \t\t MINIMUM THRESHOLD");
            for (int i = 0; i < productDL.products.Count; i++)
            {
                if (productDL.products[i].getThreshold() >= productDL.products[i].getStock())
                {
                    Console.WriteLine("{0} \t\t {1} \t\t {2}", productDL.products[i].getProductname(), productDL.products[i].getStock(), productDL.products[i].getThreshold());
                }
            }
            Console.ReadKey();
        }
    }
}
