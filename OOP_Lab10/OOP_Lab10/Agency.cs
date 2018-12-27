using System;
using System.Collections;
using System.Collections.Generic;

namespace OOP_Lab10
{
    class Agency : IComparable
    {
        readonly int maxSize;
        private Vehicle[] parkArray;

        //––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––
        public Vehicle this[int index]
        {
            get
            {
                if(index > maxSize)
                {
                    Console.WriteLine("Неверный индекс.");
                    return null;
                }
                else
                    return parkArray[index];
            }
            set
            {
                if (index > maxSize)
                {
                    Console.WriteLine("Неверный индекс.");
                }
                else
                {
                    parkArray[index] = value;
                }
            }
        }
        //––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––

        public Agency(int size)
        {
            maxSize = size;
            parkArray = new Vehicle[size];
        }

        //––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––

        public void Print()
        {
            foreach (Vehicle item in parkArray)
                Console.WriteLine($"Name: {item.Name}");
        }

        public Vehicle[] GetVehicles() => parkArray;


        public int CompareTo(object agency)
        {
            if (parkArray.Length > ((Agency)agency).parkArray.Length)
                return 1;
            if (parkArray.Length < ((Agency)agency).parkArray.Length)
                return -1;
            return 0;
        }
    }
}
