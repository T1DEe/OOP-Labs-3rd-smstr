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
        
        public Train(TrainEngine engine, int weight, int numOfCarriage)
            : base(engine, weight)
        {
            if (numOfCarriage < 0)
            {
                throw new CustomException("Кол-во вагоновы не может быть отрицательным значением.", "Train");
            }
            this.NumOfCarraige = numOfCarriage;
        }

        public override void PlaySound()
        {
            Console.WriteLine("Чуууу-чууууух");
        }
    }
}
