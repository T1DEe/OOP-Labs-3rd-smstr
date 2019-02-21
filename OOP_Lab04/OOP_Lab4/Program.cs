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
            MyList list = new MyList(1, "MAG");
            list.AddItem("Ivan");
            list.AddItem("Andrew");
            list.AddItem("Natalia");
            list.AddItem("Victor");

            string abc = "awdg fseol  ajes";
            Console.WriteLine($"Count of words: {abc.CountOfWords()}");

            list.GetOwner().GetInfo();
        }
    }
}
