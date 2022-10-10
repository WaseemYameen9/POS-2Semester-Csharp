using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sale.UI
{
    class MenusUI
    {
        public static int MainMenu()
        {

            Console.WriteLine("                _____LOGIN MENU____");
            Console.WriteLine("1-SIGN IN");
            Console.WriteLine("2-SIGN UP");
            Console.WriteLine("3-EXIT");
            Console.Write("Enter Your Option :");
            int option = int.Parse(Console.ReadLine());
            return option;
        }

        public static int AdminMenu()
        {
            Console.WriteLine(" >> ADMIN MENU :");
            Console.WriteLine("_______________________________________");
            Console.WriteLine("1.Add Product.");
            Console.WriteLine("2.View All Products.");
            Console.WriteLine("3.Find Product with Highest Unit Price.");
            Console.WriteLine("4.View Sales Tax of All Products.");
            Console.WriteLine("5.Products to be Ordered. (less than threshold)");
            Console.WriteLine("6.Exit");
            Console.WriteLine("________________________________");
            Console.Write("Enter Your Option :");
            int option = int.Parse(Console.ReadLine());
            return option;
        }

       public static int CustomerMenu()
        {
            Console.WriteLine(" >> CUSTOMER MENU :");
            Console.WriteLine("_______________________________");
            Console.WriteLine("1.View all the products");
            Console.WriteLine("2.Buy the products");
            Console.WriteLine("3.Generate invoice");
            Console.WriteLine("4.Exit");
            Console.WriteLine("________________________");
            Console.Write("Enter Your OPtion :");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
