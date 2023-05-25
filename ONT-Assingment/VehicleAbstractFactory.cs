using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT_Assingment
{
    abstract class VehicleAbstractFactory
    {
        public abstract IShell GetShell();
        public abstract IWheel GetWheel();
        public abstract ITrim GetTrim();
        public abstract IChassis GetChassis();
    }
}
