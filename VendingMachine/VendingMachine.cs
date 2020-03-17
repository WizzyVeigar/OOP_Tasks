using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineTask
{
    class VendingMachine
    {
        public event EventHandler writeEvent;
        private int money;
        public int Money
        {
            get { return money; }
            set { money = value; }
        }

        //Money the machine has saved, which isbeing picked up later
        private int machineMoney;

        public int MachineMoney
        {
            get { return machineMoney; }
            set { machineMoney = value; }
        }

        public VendingMachine()
        {
            Products = new List<Product>[5];
            for (int i = 0; i < Products.Length; i++)
            {
                Products[i] = new List<Product>();
            }
        }

        //List<Product> Could be an array if seen fit
        private List<Product>[] product;
        public List<Product>[] Products
        {
            get { return product; }
            set { product = value; }
        }

        /// <summary>
        /// Takes <paramref name="money"/> and adds it on top of the money in the machine
        /// </summary>
        /// <param name="money"></param>
        public void TakeMoney(int money)
        {
            Money += money;
        }

        /// <summary>
        /// Returns all the money that wasn't used on the purchase
        /// </summary>
        /// <returns></returns>
        public int ReturnMoney()
        {
            int temp = Money;
            Money = 0;
            writeEvent("You got " + temp + "dkk back", new EventArgs());
            return temp;
        }

        /// <summary>
        /// Buy an item after <paramref name="choice"/> while checking for various failures.
        /// Also has a chance to break down
        /// </summary>
        /// <param name="choice"></param>
        /// <returns>returns whether or not the purchase was successful</returns>
        public bool BuyItem(int choice)
        {
            Random rnd = new Random();
            //Checks if the machine had a crash
            if(rnd.Next(1,3) == 3)
            {
                writeEvent("The machine dying", new EventArgs());
            }

            if(Products[choice].Count == 0)
            {
                writeEvent("These were out of stock", new EventArgs());
                return false;
            }

            else if (Products[choice][0].Price > Money)
            {
                writeEvent("There isn't enough money in the machine", new EventArgs());
                return false;
            }
            else
            {
                //Needs to remove 1 from the products
                Money -= Products[choice][0].Price;
                Product tempItem = Products[choice].First();
                Products[choice].Remove(Products[choice].Last());
                return true;
            }
        }

        /// <summary>
        /// Refills the machine with exciting items if there is sold out, otherwise refills with the same type of item
        /// </summary>
        public void RefillItems()
        {
            foreach (List<Product> productLine in Products)
            {
                while (productLine.Count < 5)
                {
                    if (productLine.Count == 0)
                    {
                        productLine.Add(new Product("New exciting item!!", "It's Incredible!", 100000));
                    }
                    productLine.Add(new Product(productLine.First().Name, productLine[0].Flavor, productLine[0].Price));
                }
            }
        }
    }
}
