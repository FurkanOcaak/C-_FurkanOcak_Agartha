using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    internal class MyList<T>// T yerine ne verirsek o tipte bir liste oluşturur. Örneğin MyList<string> isimler = new MyList<string>(); şeklinde bir liste oluşturabiliriz.
    {
        T[] items;// T tipinde bir dizi oluşturuyoruz. Bu dizi sadece T tipinde elemanlar alabilir.
        public MyList()// constructor
        {
            items = new T[0];// dizinin boyutu 0 olarak başlatıyoruz. Yani boş bir dizi oluşturuyoruz.
        }
        public void Add(T item)// T tipinde bir parametre alıyoruz. Bu parametreyi dizimize ekleyeceğiz.
        {
            T[] tempArray = items; // geçici bir dizi oluşturuyoruz ve items dizisinin referansını ona atıyoruz.
            items = new T[items.Length + 1];// boyutu 1 arttırıyoruz ama her yeni eklenende yeni bir dizi oluşturuyoruz. Bu yüzden performans açısından kötü bir yöntemdir.
            for (int i = 0; i < tempArray.Length; i++)// geçici dizinin elemanlarını yeni dizimize kopyalıyoruz.
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;// son elemanı parametre olarak gelen item ile dolduruyoruz.

        }
        public int Length
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items; }
        }
    }
}
