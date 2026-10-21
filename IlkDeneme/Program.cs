using System;
using System.Diagnostics.Eventing.Reader;

namespace Karsılastırmalar

{
    class Program
    {
        static void Main(string[] args)
        {

            string KatagoriEtiketi = "Katagori"; //"alias"
            bool SistemGirdiMi = false;
            double DolarDun = 40;
            double DolarBugun = 41;

            if (DolarDun > DolarBugun)
            {
                Console.WriteLine("Azalış");
            }

            else if (DolarDun < DolarBugun)
            {
                Console.WriteLine("Artış");
            }
            else
            {
                Console.WriteLine("Aynı");
            }


            if (SistemGirdiMi == true)
            {
                Console.WriteLine("Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }


            Console.WriteLine(KatagoriEtiketi);
            
        }
    }
}
