using System;
using System.Collections.Generic;

namespace OOP_Lab4
{
    public class CollectionType<T> : IGenericInterface<T>
    {
        private int size;
        private List<T> list;

        public CollectionType()
        {
            list = new List<T>();
        }

        public void Add(T item)
        {
            list.Add(item);
            size++;
        }

        public void Delete(int index)
        {
            try
            {
                list.RemoveAt(index);
                size--;
            }
            catch
            {
                Console.WriteLine($"Out of range. Use number from range (0-{size})");
            }
        }

        public void Show()
        {
            foreach(T item in list)
            {
                Console.WriteLine(item);
            }
        }

        public int GetSize()
        {
            return size;
        }
    }
}
