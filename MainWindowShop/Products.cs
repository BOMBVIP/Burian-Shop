using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainWindowShop
{
    class Products
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }

        public Products(string name, double price, string image)
        {
            Name = name;
            Price = price;
            Image = image;
        }

    }
}
