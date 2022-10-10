using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_of_Sale.BL;
using Point_of_Sale.DL;
using Point_of_Sale.UI;

namespace Point_of_Sale
{
    class Program
    {
        static void Main(string[] args)
        {

            MuserDL.loadMuser();
            productDL.loadProducts();
            customerDL.loadCustomers();
            while (true)
            {
                Console.Clear();
                int option = MenusUI.MainMenu();
                if(option == 1)
                {
                        Console.Clear();
                        Console.WriteLine("___________________________");
                        Console.Write("Enter Username :");
                        string username1 = Console.ReadLine();
                        Console.Write("Enter Password :");
                        string password1 = Console.ReadLine();
                        string rolee = MuserDL.checkuser(username1, password1);
                    if (rolee == "admin")
                    {
                        while (true)
                        {
                            Console.Clear();
                            int op = MenusUI.AdminMenu();
                            if (op == 1)
                            {
                                productDL.products.Add(productUI.InputProduct());
                            }
                            if (op == 2)
                            {
                                productUI.ViewProducts();
                            }
                            if (op == 3)
                            {
                                productUI.HighestPrice();
                            }
                            if (op == 4)
                            {
                                productUI.ViewSalesTax();
                            }
                            if (op == 5)
                            {
                                productUI.ThresholdProducts();
                            }
                            if (op == 6)
                            {
                                break;
                            }
                        }
                    }
                    else if(rolee == "customer")
                    {
                        while (true)
                        {
                            Console.Clear();
                            int op = MenusUI.CustomerMenu();
                            if(op == 1)
                            {
                               productUI.ViewProducts();
                            }
                            if(op == 2)
                            {
                               customerDL.BuyProduct();
                            }
                            if(op == 3)
                            {
                                customerDL.InVoice();
                            }
                            if(op == 4)
                            {
                                break;
                            }
                        }
                    }
                   
                }

                
                if(option == 2)
                {
                    Console.Clear();
                    Console.WriteLine("_____SIGN UP_____");
                    Console.WriteLine("Enter Username :");
                    string UserName = Console.ReadLine();
                    Console.WriteLine("Enter Password :");
                    string PassWord = Console.ReadLine();
                    Console.WriteLine("Enter Role :");
                    string role = Console.ReadLine();
                    Muser user = new Muser(UserName, PassWord,role);
                    MuserDL.users.Add(user);
                    Console.Clear();
                }

                if(option == 3)
                {
                    MuserDL.storeMuser();
                    productDL.StoreProducts();
                    customerDL.StoreCustomers();
                    Console.Clear();
                    break;
                }
            }
        }
    }
}
