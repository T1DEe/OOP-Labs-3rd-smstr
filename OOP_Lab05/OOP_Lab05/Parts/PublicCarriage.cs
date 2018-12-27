using System;
namespace OOP_Lab05
{
    class PublicCarriage : Сarriage, IExpressCarriage
    {
        private int dragCoef;
        public int DragCoef
        {
            get => dragCoef;

            set
            {
                if (value < 25)
                {
                    dragCoef = value;
                }
            }
        }

        public int NumOfPlaces { get; }
        public string Color { get; set; }
        public string NameOfСonductor { get; set; }

       
        public PublicCarriage(int length, int heigth, int numOfPlaces, string color, string nameOfConductor) 
            : base(length, heigth)
        {
            this.NumOfPlaces = numOfPlaces;
            this.Color = color;
            this.NameOfСonductor = nameOfConductor;
        }

        public PublicCarriage() 
            : base(10, 3)
        {
            this.NumOfPlaces = 50;
            this.Color = "Blue";
            this.NameOfСonductor = "None";
        }

        public void GetInfo()
        {
            Console.WriteLine("Number of Places: {0}, Color of carriage: {1}, Name of conductor: {2}.", NumOfPlaces, Color, NameOfСonductor);
        }

        public string SpeedUpBy()
        {
            return "Уменьшение коэффициента сопротивления воздуха и модернизация колес";
        }

        void IExpressCarriage.DoSomething()
        {
            Console.WriteLine(1);
        }

        public override void DoSomething()
        {
            Console.WriteLine(2);
        }
    }
}
