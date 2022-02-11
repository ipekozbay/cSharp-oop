using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "elma";
            product1.Description = "amasya elması";
            product1.Price = 11;

            Product product2 = new Product();
            product2.Name = "karpuz";
            product2.Price = 262;
            product2.Description = "diyarbakır karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Description);
                Console.WriteLine(product.Price);
            }

            CartManager cartManager = new CartManager();
            cartManager.Add(product1);

        }
    }
}

// dont repeat yourself!!!!  - best practice