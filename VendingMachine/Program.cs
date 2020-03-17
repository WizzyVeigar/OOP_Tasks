using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Product snack1 = new Product("Twix", "Delicious", 10);
            Product snack2 = new Product("Nuts", "NutsAboutThem", 5);
            Product snack3 = new Product("Cupnoodles", "Extravagant", 50);
            Product snack4 = new Product("Cookies", "Splendid", 35);
            Product snack5 = new Product("Cereal", "Superbowl", 150);
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.writeEvent += VendingMachine_writeEvent;


            vendingMachine.Products[0].Add(snack1);
            vendingMachine.Products[1].Add(snack2);
            vendingMachine.Products[2].Add(snack3);
            vendingMachine.Products[3].Add(snack4);
            vendingMachine.Products[4].Add(snack5);

            while (true)
            {
                Console.Clear();

                Console.WriteLine(
                    "Welcome to vendingmachine \n" +
                    "1. Buy Item \n" +
                    "2. Give Money\n" +
                    "3. Refill Items\n");
                string input = Console.ReadLine();

                //Switch case for user input
                switch (input)
                {
                    //Case for buying an item
                    case "1":
                        Console.Clear();
                        foreach (List<Product> productLine in vendingMachine.Products)
                        {
                            if (productLine.Count == 0)
                            {
                                Console.WriteLine("Sold out!");
                            }
                            else
                                Console.WriteLine(productLine.First().Name + "   " + productLine.First().Price);
                        }

                        Console.WriteLine("What would you like to buy?");
                        input = Console.ReadLine();
                        Console.WriteLine("Are you sure? y/n");
                        string temp = Console.ReadLine().ToLower();
                        if (temp == "y")
                        {
                            if (vendingMachine.BuyItem(int.Parse(input)))
                                Console.WriteLine("Purchase was completed successfully! enjoy your snack");
                            break;
                        }
                        break;

                    //Case for feeding the machine cash
                    case "2":
                        Console.Clear();
                        Console.WriteLine("How much money would you like to give");
                        vendingMachine.TakeMoney(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Money was taken successfully");
                        break;

                    //case for refilling the machine
                    case "3":
                        vendingMachine.RefillItems();
                        break;

                    default:
                        Console.WriteLine("Enter 1-3 Otherwise you suck");
                        break;
                }
                Console.ReadKey();
            }
        }

        //Write to console event
        private static void VendingMachine_writeEvent(object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString());
        }
    }
}
