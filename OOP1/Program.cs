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
            product1.CatagoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CatagoryId = 5, 
                ProductName = "Kalem", UnitPrice = 35, UnitsInStock = 5 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Add(product2);

            productManager.Topla2(123, 456);


            ///int ToplamaSonucu = productManager.Topla1(10, 20);
            Console.WriteLine(productManager.Topla1(10, 20) * 2);


        }
    }
}
