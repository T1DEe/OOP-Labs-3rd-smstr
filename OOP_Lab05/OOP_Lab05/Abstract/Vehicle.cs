using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab05
{
    abstract class Vehicle
    {
        public IEngine Engine { get; set; }
        public int Weight { get; set; }

        public Vehicle(IEngine engine, int weight)
        {
            this.Engine = engine;
            if (weight > 0)
            {
                this.Weight = weight;
            }
            else
            {
                throw new VehicleExсeption("Масса не может быть отрицательным значением.", weight);
            }
        }

        public abstract void PlaySound();
        public virtual int GetMaxSpeed()
        {
            return Engine.HorsePower / Weight; 
        }
    }
}
