using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab05
{
    abstract class Сarriage
    {
        public int Length { get; }
        public int Height { get; }

        public Сarriage(int lenght, int height)
        {
            this.Length = lenght;
            this.Height = height;
        }

        public abstract void DoSomething();
    }
}
