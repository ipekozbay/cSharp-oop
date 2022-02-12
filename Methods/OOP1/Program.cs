using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "table";
            product1.UnitsInStock = 10;
            product1.UnitPrice = 456;

            ProductManager productManager1 = new ProductManager();
            productManager1.Add(product1);
        }
    }
}