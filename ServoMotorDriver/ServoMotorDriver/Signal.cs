using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServoMotorDriver
{
    class Signal
    {
        public string Name;
        public double Value;
        public string Units;

        public Signal()
        {
            Name = "Defaul";
            Value = 0.0;
            Units = "Default";
        }
    }
}
