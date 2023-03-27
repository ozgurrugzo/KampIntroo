using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        T[] items;
        //constructor ctor tab-tab
        public MyList()
        {
            items= new T[0]; // Buradaki T type'dan gelir. T türünde çeşitli veri tipleri tutabilecek bir veri tipi  yaptık.
        }
        public void Add(T item)
        {
            T[] tempArray = items; //items ın referansı kaybolup içerisindeki elemanlar kaybolmasın diye geçici bir arrayde tuttuk. 
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; //burada items ile tempArray'deki elemanları eşitledik.
        }
    }
}
