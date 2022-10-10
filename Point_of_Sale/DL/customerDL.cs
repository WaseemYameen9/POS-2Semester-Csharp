using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_of_Sale.BL;
using Point_of_Sale.UI;
using System.IO;

namespace Point_of_Sale.DL
{
    class customerDL
    {
        public static customer customers = new customer();
        public static void BuyProduct()
        {
            Console.Clear();
            double price, tax, total = 0;
            Console.WriteLine("    _______CUSTOMER MENU________");
            Console.WriteLine("________________________________");
            int nmber = int.Parse(customerUI.GetLine("How many products You want to enter :"));
            for (int i = 0; i < nmber; i++)
            {
                string productname = customerUI.GetLine("Product Name :");
                int quantity = int.Parse(customerUI.GetLine(" Quantity :"));
                for (int j = 0; j < productDL.products.Count; j++)
                {
                    if (productDL.products[j].getProductname() == productname)
                    {
                        price = productDL.products[j].getPrice() * quantity;
                        tax = productDL.products[j].getSalesTax();
                        price = (price + ((price / 100f) * tax));
                        productDL.products[j].setStock(productDL.products[j].getStock() - quantity);
                        total = total + price;
                        customers.getCproducts().Add(productDL.products[j]);

                    }
                }

                customers.setBill(total);
            }
        }

        public static void InVoice()
        {
            Console.Clear();
            Console.WriteLine("___________________CUSTOMER_______________");
            Console.WriteLine("Name \t\t Price");
            for (int i = 0; i < customers.getCproducts().Count; i++)
            {
                customerUI.PrintInvoice(customers.getCproducts()[i].getProductname(), customers.getCproducts()[i].getPrice());
            }

            customerUI.PrintBill(customers.getBill());
            Console.ReadKey();
        }
        public static void StoreCustomers()
        {
            string path = "E:\\Semester 2\\OOP\\week5\\Assignment\\Point_of_Sale\\customer.txt";
            string totalproducts =  "";
            StreamWriter f = new StreamWriter(path);
            for (int i = 0; i < customers.getCproducts().Count - 1; i++)
            {
                totalproducts = totalproducts + customers.getCproducts()[i].getProductname() + ';';
            }
            totalproducts = totalproducts + customers.getCproducts()[customers.getCproducts().Count - 1].getProductname();
            f.WriteLine("{0},{1}",customers.getBill(), totalproducts);
            f.Flush();
            f.Close();

        }

        public static void loadCustomers()
        {
            int idx;
            string path = "E:\\Semester 2\\OOP\\week5\\Assignment\\Point_of_Sale\\customer.txt";
            StreamReader f = new StreamReader(path);
            string record;
            while ((record = f.ReadLine()) != null)
            {
                string[] splittedrecord = record.Split(',');
                double bill = double.Parse(splittedrecord[0]);
                customers.setBill(bill);
                string[] splittedproducts = splittedrecord[1].Split(';');
                
                for (int i = 0; i < splittedproducts.Length; i++)
                {
                  idx =  productDL. getProductsData(splittedproducts[i]);
                    customers.getCproducts().Add(productDL.products[idx]);

                }
              
            }
            f.Close();
        }

    }
}
