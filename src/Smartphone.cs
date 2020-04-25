using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    class Smartphone
    {
        public string Brand;
        public string Model;
        public double Price;

        public Smartphone(string brand, string model, double price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Price = price;
        }

        public Smartphone()
        {
            this.Brand = "";
            this.Model = "";
            this.Price = 0;
        }

    }
}
