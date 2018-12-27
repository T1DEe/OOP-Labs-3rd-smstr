using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab4
{
    static class MathOperation
    {
        public static string Max(List list)
        {
            string str = list.list[0];
            foreach (string item in list.list)
            {
                if(str.Length < item.Length)
                {
                    str = item;
                }
            }
            return str;
        }

        public static string Min(List list)
        {
            string str = list.list[0];
            foreach (string item in list.list)
            {
                if (str.Length > item.Length)
                {
                    str = item;
                }
            }
            return str;
        }

        public static int Length(List list)
        {
            int count = list.list.Length;
            return count;
        }

        public static int CountOfWords(this string str)
        {
            int count = 0;
            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                count += words.Length;
            return count;
        }

        public static bool IsEmptyElement(this List list)
        {
            foreach (string item in list.list)
            {
                if (item == "")
                {
                    return true;
                }
            }
            return false;
        }
    }
}
