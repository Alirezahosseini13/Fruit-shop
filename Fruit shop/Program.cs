using System;
using System.Collections.Generic;
using Fruit_shop;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_shop
{
    internal class Program
    {
        static Dictionary<string, int> Adp = new Dictionary<string, int>();
        static Dictionary<string, int> ShoppingBag = new Dictionary<string, int>();
        static void Main(string[] args)
        {

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("..............Welcome To The Fruit Store.............. ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(".... Press Enter 1 to See the Part of Buying Goods   ....  ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(".... Press Enter 2 to see the Part of Shop Assistant ....");
                Console.ResetColor(); 
                string user = Console.ReadLine();
                while (true)
                {
                    if (user == "2")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Enter Password :");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Enter 0 to Back");
                        Console.ResetColor();
                        string pas = Console.ReadLine();
                        if (pas == "110")
                        {
                            while (true)
                            {
                                try
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.WriteLine("Select The Operation You Want : ");
                                    Console.ResetColor();
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("Enter 1 For Add Fruit And Determining the Price of Fruits");
                                    Console.WriteLine("Enter 2 For Delete Fruit");
                                    Console.ResetColor();
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("Enter 0 to Back");
                                    Console.ResetColor();
                                    string Select = (Console.ReadLine());

                                    if (Select == "1")
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.Write("Enter the Name : ");
                                        Console.ResetColor();
                                        string name = Console.ReadLine();
                                        if (string.IsNullOrWhiteSpace(name))
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("name Cannot be Empty");
                                            Console.ResetColor();
                                            Console.ReadKey();
                                            return;
                                        }
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.Write("Enter the price : ");
                                        Console.ResetColor();
                                        int Price = Convert.ToInt32(Console.ReadLine());
                                        if (Adp.ContainsKey(name))
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("This Fruit Already Exist!!!");
                                            Console.ResetColor();
                                            Console.ReadKey();
                                            return;
                                        }
                                        AddFruit(name, Price);
                                        Console.ForegroundColor = ConsoleColor.DarkGray;
                                        Console.WriteLine("Your Operation was Successfully Completed");
                                        Console.ResetColor();
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.Write("Press Enter To Back To the Menu");
                                        Console.ResetColor();
                                        Console.ReadLine();
                                    }
                                    else if (Select == "2")
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.Write("Enter a name to Delete :");
                                        Console.ResetColor();
                                        string deleteName = Console.ReadLine();
                                        deleteFruit(deleteName);

                                    }
                                    else if (Select == "0")
                                    {
                                        Console.Clear();
                                        break;
                                    }

                                }
                                catch (Exception ex)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"Error!!!!! { ex.Message}");
                                    Console.ResetColor();
                                }

                            }

                        }
                        else if (pas == "0")
                        {
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("The Password is not Correct");
                            Console.ResetColor();
                            Console.ReadKey();
                        }
                    }

                    else if (user == "1")
                    {
                        while (true)
                        {
                            try
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Select The Operation You Want : ");
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Enter 1 for See the Fruit Menu : ");
                                Console.WriteLine("Enter 2 for Buy Fruit : ");
                                Console.WriteLine("Enter 3 for View Shopping Bag : ");
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Enter 0 to Exit   ");
                                Console.ResetColor();
                                string Select2 = Console.ReadLine();
                                if (Select2 == "1")
                                {
                                    displayFruit();
                                }
                                else if (Select2 == "2")
                                {
                                    while (true)
                                    {
                                        Console.WriteLine("Enter the Name Of The Fruit You Want  : ");
                                        string buy = Console.ReadLine();
                                        Console.WriteLine("How Much Fruit Do You Want?  : ");
                                        int buy2 = Convert.ToInt32(Console.ReadLine());
                                        BuyFruit(buy, buy2);
                                        Console.WriteLine("Press Enter to Continue ");
                                        Console.WriteLine("Enter 0 to Back ");
                                        string kye = Console.ReadLine();
                                        if (kye == "0") { break; }
                                    }

                                }
                                else if (Select2 == "3")
                                {
                                    Shoppingbag();
                                }
                                else if (Select2 == "0")
                                {
                                    return;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Please Select The Correct Option");
                                    Console.ResetColor();
                                    Console.ReadKey();
                                    return;
                                }


                            }
                            catch (Exception ex) { Console.WriteLine(ex.Message); break; }
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please Select The Correct Option");
                        Console.ResetColor();
                        Console.ReadKey();
                        return;
                    }

                }


            }




            void deleteFruit(string fullName)
            {
                if (Adp.ContainsKey(fullName))
                {
                    Adp.Remove(fullName);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("The Operation Was Successful");
                    Console.ResetColor();
                }

            }
            void AddFruit(string name, int Price)
            {
                Adp.Add(name, Price);
            }

            void displayFruit()
            {
                foreach (KeyValuePair<string, int> pair in Adp)
                {
                    Console.WriteLine($"{pair.Key} : {pair.Value}");
                }

            }
            void BuyFruit(string Buy, int Buy2)
            {
                foreach (KeyValuePair<string, int> pair in Adp)
                {
                    if (Buy == pair.Key)
                    {
                        int value = Buy2 * pair.Value;
                        ShoppingBag.Add(pair.Key, value);
                    }
                    else
                    {   
                        Console.ForegroundColor=ConsoleColor.DarkRed;
                        Console.WriteLine("The fruit you were looking for was not found");
                        Console.ResetColor();
                        Console.ReadKey();
                        return;
                    }

                }

            }
            void Shoppingbag()
            {
                foreach (KeyValuePair<string, int> pair in ShoppingBag)
                {
                    Console.WriteLine($"{pair.Key} : {pair.Value}");
                }
            }

        }
    }
}
