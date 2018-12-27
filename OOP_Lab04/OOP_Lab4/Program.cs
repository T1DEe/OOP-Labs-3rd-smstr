using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            List a = new List(10);
            a.AddItem("a");
            a.AddItem("b");
            a.AddItem("c");
            a.AddItem("d");

            List.Owner a2 = new List.Owner();
            string abc = "awdg fseol  ajes";
            Console.WriteLine(abc.CountOfWords());

            Console.ReadKey();
        }
    }
}
