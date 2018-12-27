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
            CollectionType<int> collectInt = new CollectionType<int>();
            CollectionType<float> collectFloat = new CollectionType<float>();
            CollectionType<string> collectString = new CollectionType<string>();

            collectInt.Add(5);
            collectInt.Add(100);
            collectInt.Add(200);
            collectInt.Delete(1);
            collectInt.Show();

            CollectionType<Company> collectCompany = new CollectionType<Company>();

            collectCompany.Add(new Company("artemy", 2017, "artemy"));



            Console.ReadKey();
        }
    }
}
