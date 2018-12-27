//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOP_Lab4
//{
//    public class List
//    {
//        // Поля
//        public Date date;
//        private readonly int maxSize;
//        public int Size { get; set; }
//        public string[] list;

//        // Свойства
//        public int MaxSize
//        {
//            get
//            {
//                return maxSize;
//            }
//        }
        
//        // Констукторы
//        public List(int maxSize)
//        {
//            this.maxSize = maxSize;
//            list = new string[maxSize];
//        }

//        // Методы
//        public bool AddItem(string item)
//        {
//            if ((Size + 1) < maxSize)
//            {
//                Size++;
//                list[Size] = item;
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }

//        public bool DeleteLast()
//        {
//            if(Size > 0)
//            {
//                Size--;
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }

//        // Перегрузка операторов
//        public static bool operator +(List list, string item)
//        {
//            list.list.Append(item);
//            return true;
//        }

//        public static List operator --(List list)
//        {
//            list.DeleteLast();
//            return list;
//        }

//        public static bool operator !=(List one, List two)
//        {
//            foreach (string item1 in one.list)
//            {
//                foreach (string item2 in two.list)
//                {
//                    if(item1 != item2)
//                    {
//                        return true;
//                    }
//                }
//            }
//            return false;
//        }

//        public static bool operator ==(List one, List two)
//        {
//            foreach (string item1 in one.list)
//            {
//                foreach (string item2 in two.list)
//                {
//                    if (item1 != item2)
//                    {
//                        return false;
//                    }
//                }
//            }
//            return true;
//        }

//        public static bool operator true(List list)
//        {
//            foreach (string item in list.list)
//            {
//                if(item.Length > (item+1).Length)
//                {
//                    return false;
//                }
//            }
//            return true;
//        }

//        public static bool operator false(List list)
//        {
//            foreach (string item in list.list)
//            {
//                if (item.Length > (item + 1).Length)
//                {
//                    return true;
//                }
//            }
//            return false;
//        }

//        public class Owner
//        {
//            private static readonly int id = 021199;
//            private static readonly string fio = "MAG";

//            public void GetInfo()
//            {
//                Console.WriteLine("{0}, {1}", id, fio);
//            }
//        }

       

//    }
//}

//public class Date
//{
//    public static readonly DateTime time = DateTime.Now;
//}