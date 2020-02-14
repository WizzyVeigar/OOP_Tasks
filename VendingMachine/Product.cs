using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineTask
{
    class Product
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string flavor;

        public string Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }

        private int price;


        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public Product(string name, string flavor, int price)
        {
            Name = name;
            Flavor = flavor;
            Price = price;
        }
    }
}
