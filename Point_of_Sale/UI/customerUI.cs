using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sale.UI
{
    class customerUI
    {
        public  static string GetLine(string statement)
        {
            Console.Write("Enter " + statement);
            string line = Console.ReadLine();
            return line;
        }

        public static void PrintInvoice(string productname,int productprice)
        {
            Console.WriteLine("{0} \t\t {1}", productname, productprice);
        }

        public static void PrintBill(double bill)
        {
            Console.WriteLine("Your Bill after Sales Tax : {0}", bill);
        }
    }
}
