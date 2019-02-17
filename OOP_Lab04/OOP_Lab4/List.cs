using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace OOP_Lab4
{
    public class List
    {
        // ПОЛЯ =======================================================
        private readonly Owner owner;
        private readonly Date date = new Date();
        private List<string> collection;

        // СВОЙСТВА ===================================================
        public int Size { get; }

        // КОНСТРУКТОРЫ ===============================================
        public List(int ownerID, string ownerFIO)
        {
            this.owner = new Owner(ownerID, ownerFIO);
        }

        // МЕТОДЫ =====================================================
        public void AddItem(string item)
        {
            collection.Add(item);
        }

        public void DeleteLast()
        {

        }

        // ПЕРЕГРУЗКИ =================================================
        public static bool operator +(List list, string item)
        {
            list.list.Append(item);
            return true;
        }

        public static List operator --(List list)
        {
            list.DeleteLast();
            return list;
        }

        public static bool operator !=(List one, List two)
        {
            foreach (string item1 in one.list)
            {
                foreach (string item2 in two.list)
                {
                    if(item1 != item2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator ==(List one, List two)
        {
            foreach (string item1 in one.list)
            {
                foreach (string item2 in two.list)
                {
                    if (item1 != item2)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator true(List list)
        {
            foreach (string item in list.list)
            {
                if(item.Length > (item+1).Length)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool operator false(List list)
        {
            foreach (string item in list.list)
            {
                if (item.Length > (item + 1).Length)
                {
                    return true;
                }
            }
            return false;
        }


        public class Owner
        {
            private readonly int id;
            private readonly string fio;

            public Owner(int id, string fio)
            {
                this.id = id;
                this.fio = fio;
            }

            public void GetInfo()
            {
                Console.WriteLine($"Owner – ID: {id}, FIO: {fio}.");
            }
        }

        public class Date
        {
            public readonly DateTime time;

            public Date()
            {
                time = DateTime.Now;
            }
        }
    }
}