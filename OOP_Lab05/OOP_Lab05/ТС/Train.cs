using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab05
{
     class Train : Vehicle
    {
        public int NumOfCarraige { get; set; }


        public Train(TrainEngine engine, int weight, int waste, int numOfCarriage)
            : base(engine, weight)
        {
            this.
        }

        public Train(IEngine engine, string color) : base(engine)
        {
            engine = new TrainEngine();
            Color = color;
        }

        public Train(IEngine engine, int horsePower, int maxSpeed, int waste, string color) : base(engine)
        {
            engine = new TrainEngine(horsePower, maxSpeed, waste);
            Color = color;
        }
    }
}
