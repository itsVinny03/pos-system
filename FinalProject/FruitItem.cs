using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class FruitItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public FruitItem(string name, decimal price, int quantity = 1)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }

}
