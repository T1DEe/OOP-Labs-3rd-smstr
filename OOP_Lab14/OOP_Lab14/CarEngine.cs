using System;
namespace OOP_Lab14
{
    [Serializable]
    public class CarEngine : IEngine
    {
        public int HorsePower { get; }
        public string Developer { get; }

        
        public CarEngine()
        {
            HorsePower = 180;
            Developer = "None";
        }

        public CarEngine(int horsePower, string developer)
        {
            this.HorsePower = horsePower;
            this.Developer = developer;
        }

        public void Start()
        {
            Console.WriteLine("Машина заведена.");
        }

        public void Stop()
        {
            Console.WriteLine("Машина остановлена.");
        }
    }
}
