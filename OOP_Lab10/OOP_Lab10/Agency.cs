using System;
using System.Collections;
using System.Collections.Generic;

namespace OOP_Lab05
{
    class Agency
    {

        public struct Title
        {
            public string name;
            public int id;

            public Title(string name, int id)
            {
                if(name == "")
                {
                    throw new AgencyException("Имя агенства не может быть пустым.",name, id);
                }
                this.name = name;
                this.id = id;
            }
        }

        public  List<Vehicle> parkArray;

        // индексатор
        //public Vehicle this[int index]
        //{
        //    get
        //    {
        //        if(index > size)
        //        {
        //            Console.WriteLine("Неверный индекс.");
        //            return null;
        //        }
        //        else
        //        {
        //            return parkArray[index];
        //        }
        //    }
        //    set
        //    {
        //        if (index > size)
        //        {
        //            Console.WriteLine("Неверный индекс.");
        //        }
        //        else
        //        {
        //            parkArray[index] = value;
        //        }
        //    }
        //}
        //––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––

        public Agency()
        {
            parkArray = new List<Vehicle>();
            Title title = new Title("default", 0);
        }

        public Agency(string titleName, int titleId)
        {
            parkArray = new List<Vehicle>();
            Title title = new Title(titleName, titleId);
        }

        //––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––
        public void Delete(int index)
        {
            parkArray.RemoveAt(index);
        }


        public void Add(Vehicle item)
        {
            parkArray.Add(item);
        }


        public int GetCommonWeight()
        {
            int commonWeight = 0;
            foreach(Vehicle item in parkArray)
            {
                return commonWeight += item.Weight;
            }
            return commonWeight;
        }
    }
}
