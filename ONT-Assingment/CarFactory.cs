using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT_Assingment
{
    class CarFactory : VehicleAbstractFactory
    {

        public override IChassis GetChassis()
        {
            return new CarChassis();
        }


        public override IShell GetShell()
        {
            return new CarShell();
        }

        public override IWheel GetWheel()
        {
            return new CarWheel();
        }


        public override ITrim GetTrim()
        {
            return new CarInteriorTrim();
        }
    }
}
