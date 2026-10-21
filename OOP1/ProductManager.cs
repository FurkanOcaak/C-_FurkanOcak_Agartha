using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    internal class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        public void Delete(Product product)
        {
            Console.WriteLine(product.ProductName + " silindi.");
        }

        public int Topla1(int sayi1, int sayi2)
        {// return type is int => to return the result to the caller
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {// return type is void => to print the result directly
            Console.WriteLine(sayi1 + sayi2);
        }
        
    }
}
