using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT_Assingment
{
    class MinibusFactory : VehicleAbstractFactory
    {

        public override IChassis GetChassis()
        {
            return new MinibusChassis();
        }


        public override IShell GetShell()
        {
            return new MinibusShell();
        }

        public override IWheel GetWheel()
        {
            return new MinibusWheel();
        }


        public override ITrim GetTrim()
        {
            return new MinibusInteriorTrim();
        }
    }
}
