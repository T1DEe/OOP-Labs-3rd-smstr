using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab05
{
    interface IEngine
    {
        int HorsePower { get; }

        void Start();
        void Stop();
    }
}
