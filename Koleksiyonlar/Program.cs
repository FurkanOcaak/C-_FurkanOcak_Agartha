using System.Net;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Ahmet", "Mehmet", "Ayşe", "Fatma", };
            //foreach (var isim in isimler)
            //{
            //    Console.WriteLine(isim);
            //} ctrl + k + c ile yorum satırı yapabiliriz, ctrl + k + u ile yorum satırını kaldırabiliriz.

            List<string> isimler2 = new List<string> { "Ahmet", "Mehmet", "Ayşe", "Fatma", };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("C");
            Console.WriteLine(isimler2[4]);


        }
    }
}
