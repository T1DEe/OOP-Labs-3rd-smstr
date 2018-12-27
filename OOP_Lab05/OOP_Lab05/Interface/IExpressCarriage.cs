using System;
namespace OOP_Lab05
{
    public interface IExpressCarriage
    {
        int DragCoef { get; set; }

        string SpeedUpBy();
        void DoSomething();
    }
}
