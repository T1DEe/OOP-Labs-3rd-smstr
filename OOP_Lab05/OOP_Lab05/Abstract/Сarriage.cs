using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab05
{
    class Сarriage
    {
        public int NumOfPlaces { get; }
        public string Color { get; set; }
        public string NameOfСonductor { get; set; }

        public Сarriage(int numOfPlaces, string color, string nameOfConductor)
        {
            this.NumOfPlaces = numOfPlaces;
            this.Color = color;
            this.NameOfСonductor = nameOfConductor;
        }

        public Сarriage()
        {
            this.NumOfPlaces = 50;
            this.Color = "Blue";
            this.NameOfСonductor = "None";
        }

        public void GetInfo()
        {
            Console.WriteLine("Number of Places: {0}, Color of carriage: {1}, Name of conductor: {2}.", NumOfPlaces, Color, NameOfСonductor);
        }

    }
}
