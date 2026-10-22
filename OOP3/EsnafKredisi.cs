using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class EsnafKredisi: IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }
        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı.");
        }
    
    }
}
