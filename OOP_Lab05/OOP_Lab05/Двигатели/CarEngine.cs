using System;
namespace OOP_Lab05.Классы
{
    public class CarV6Engine : IEngine
    {
        public int HorsePower { get; }
        public int MaxSpeed { get; }
        public string Developer { get; }

        public CarV6Engine()
        {
            HorsePower = 100;
            MaxSpeed = 100;
            Developer = "Mercedes";
        }

        public void Start()
        {
            Console.WriteLine("V6 заведен.");
        }

        public void Stop()
        {
            Console.WriteLine("V6 остановлен.");
        }
    }
}
