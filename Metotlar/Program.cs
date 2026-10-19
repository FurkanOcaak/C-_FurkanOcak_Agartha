using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product Product1 = new Product();
            Product1.Adi = "Elma";
            Product1.Fiyati = 15;
            Product1.Aciklama = "Amasya Elması";


            Product Product2 = new Product();
            Product2.Adi = "Karpuz";
            Product2.Fiyati = 80;
            Product2.Aciklama = "İyi karpuz";

            Product[] Products = new Product[] { Product1, Product2 };

            foreach (Product product in Products)
            {
                Console.WriteLine(product.Adi + " : " + product.Fiyati + " : " + product.Aciklama  );
            }

            Console.WriteLine("-----------METHODS---------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(Product1);    
            sepetManager.Ekle(Product2);


            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 15);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 18, 9);
            sepetManager.Ekle2("Karpuz", "Tatlı Karpuz", 15, 14);


        }
    }
}
