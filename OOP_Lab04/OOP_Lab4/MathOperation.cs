using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab4
{
    static class MathOperation
    {
        public static string Max(MyList list)
        {
            string str = list.GetItemByIndex(0);
            foreach (string item in list.GetList())
            {
                if(str.Length < item.Length)
                {
                    str = item;
                }
            }
            return str;
        }

        public static string Min(MyList list)
        {
            string str = list.GetItemByIndex(0);
            foreach (string item in list.GetList())
            {
                if (str.Length > item.Length)
                {
                    str = item;
                }
            }
            return str;
        }

        public static int CountOfWords(this string str)
        {
            int count = 0;
            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                count += words.Length;
            return count;
        }

        public static bool IsContainsEmptyElement(this MyList list)
        {
            foreach (string item in list.GetList())
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
