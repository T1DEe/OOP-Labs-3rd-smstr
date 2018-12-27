using System;
namespace OOP_Lab09
{
    public class Class
    {
        public static void Work(int time) => Console.WriteLine($"User is working {time} years");

        public static void Upgrade(int level)
        {
            Console.WriteLine("Level upgrated to " + level);
        }

        public void PrintMassege(string massege)
        {
            Console.WriteLine(massege);
        }
    }
}
