using System;
using System.Collections.Generic;

namespace OOP_Lab4
{
    public interface IGenericInterface<T>
    {
        void Add(T item);
        void Delete(int index);
        void Show();
    }
}
