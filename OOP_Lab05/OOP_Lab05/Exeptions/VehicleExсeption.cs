using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab05
{
    class VehicleExсeption : CustomException
    {
        public int ErrorWeight { get; set; }

        public VehicleExсeption(string message, int errorWeight)
            : base(message, "Vehicle")
        {
            this.ErrorWeight = errorWeight;
        }
    }
}
