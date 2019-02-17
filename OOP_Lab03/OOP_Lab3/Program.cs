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
            Time one = new Time(5);
            Time two = new Time();
            Time three = new Time(10,40,50);
            Time four = new Time(hour: 5,second: 12);
            Time five = new Time(second: 36);

            Console.WriteLine(four);

            Time[] timeArray = { one, two, three, four, five};

            Time.GetInfo();

            var myView = new { hour = 1, minute = 40, second = 59 };

            Console.WriteLine("Введите число: ");
            int number = int.Parse(Console.ReadLine());
            foreach (Time item in timeArray)
            {
                if(item.Hour == number)
                    Console.WriteLine(item);
            }

            Time.HoursSum(one, two, out five);
            one.Equals(two);



            Console.ReadKey();
        }
    }
}
