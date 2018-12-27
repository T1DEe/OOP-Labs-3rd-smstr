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
            this.Weight = weight;
        }

        public abstract void PlaySound();
        public virtual int GetMaxSpeed()
        {
            return Engine.HorsePower / Weight; 
        }
    }
}
