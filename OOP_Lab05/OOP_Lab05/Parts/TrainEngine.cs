using System;
namespace OOP_Lab05
{
    public class TrainEngine : IEngine
    {
        public int HorsePower { get; }
        public int Waste { get; }


        public TrainEngine()
        {
            HorsePower = 1500;
            Waste = 50;
        }

        public TrainEngine(int horsePower, int waste)
        {
            this.HorsePower = horsePower;
            this.Waste = waste;
        }

        public void Start()
        {
            Console.WriteLine("Двигатель поезда работает.");
        }

        public void Stop()
        {
            Console.WriteLine("Двигатель поезда не работает.");
        }
    }
}
