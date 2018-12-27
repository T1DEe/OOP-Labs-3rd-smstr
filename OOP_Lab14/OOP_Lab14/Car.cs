using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab14
{
    [Serializable]
    public class Car : Vehicle
    {
        public int Length { get; }

        public Car()
            : base(new CarEngine(), 2000)
        {
            this.Length = 1500;
        }


        public Car(CarEngine engine, int weight, int length) 
            : base(engine, weight)
        {
            if (length < 0)
            {
                throw new CustomException("Длина не может быть отрицательным значением.", "Car");
            }
            this.Length = length;
        }

        public override void PlaySound()
        {
            Console.WriteLine("Вжжжж-жжжжжж-жжжжжж");
        }
    }   
}
