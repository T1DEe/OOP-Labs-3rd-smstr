using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab05
{
    class Car : Vehicle
    {
        int Length { get; }

        public Car(CarEngine engine, int weight, int length) 
            : base(engine, weight)
        {
            this.Length = length;
        }

        public override void PlaySound()
        {
            Console.WriteLine("Вжжжж-жжжжжж-жжжжжж");
        }

    }   
}
