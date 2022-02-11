using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class CartManager
    {
        // Simulation
        public void Add(Product product)
        {
            Console.WriteLine("added to cart: " + product.Name);
        }

    }
}