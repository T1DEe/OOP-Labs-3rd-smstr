using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Time_Class one = new Time_Class(5);
            Time_Class two = new Time_Class();
            Time_Class three = new Time_Class(10,40,50);

            Time_Class[] array = { one, two, three};

            Time_Class.Info();

            var myView = new { hour = 1, minute = 40, second = 59 };

            Console.WriteLine("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            foreach (Time_Class item in array)
            {
                if(item.Hour == number)
                {
                    Console.WriteLine("hour = {0}, minute = {1}, second = {2}", item.Hour, item.Minute, item.Second);
                }
            }

            Time_Class a2 = new Time_Class(2);
            Time_Class a3 = new Time_Class(5);
            Time_Class a4 = new Time_Class();
            Time_Class a1 = new Time_Class();
            Console.WriteLine(a1.SumOfHourTime(ref a2, ref a3, out a4));

            Console.ReadKey();
        }
    }
}
