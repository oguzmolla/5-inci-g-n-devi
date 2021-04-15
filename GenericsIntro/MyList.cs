using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    // Burada verdiğimiz T object türdür. 
    // Oluştururken ne verirsek odur.
    class MyList<T>
    {
        T[] _items;

        public MyList()
        {
            _items = new T[0];
        }

        public void Add(T item)
        {
            // Geçici olarak heap teki yerini kaybetmemk için geçici diziye attık
            T[] tempArray = _items;
            _items = new T[_items.Length + 1];

            // geçici listeyi yeni listeye ekledik
            for (int i = 0; i < tempArray.Length; i++)
            {
                _items[i] = tempArray[i];
            }

            // yeni eklenecek datayıda items datasına ekledik
            _items[_items.Length - 1] = item;
        }

        public int Length
        {
            get { return _items.Length; }
        }

        public T[] Items
        {
            get { return _items; }
        }
    }
}
