using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    class Smartphone
    {
        public string Brand = "";
        public string Model = "";
        public double Price = 0;

        public Smartphone(string brand, string model, double price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Price = price;
        }

    }
}
