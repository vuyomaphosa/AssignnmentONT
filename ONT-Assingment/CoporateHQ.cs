using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT_Assingment
{
    abstract class CoporateHQ
    {
        public abstract VehicleAbstractFactory TheFactory { get; set; }
        public CoporateHQ(VehicleAbstractFactory TheFactory)
        {
            this.TheFactory = TheFactory;
        }

        public VehicleClient assembleVehicle(string ColourType, string VehcleType)
        {
            VehicleClient vehicleClient = null;
            if (TheFactory != null)
            {
                vehicleClient = makeVehicle(ColourType, VehcleType);
                if (vehicleClient != null)
                {
                    vehicleClient.AddWheel();
                    vehicleClient.AddChassis();
                    vehicleClient.AddShell();
                    vehicleClient.AddTrim();

                }
            }
            return vehicleClient;
        }
        public abstract VehicleClient makeVehicle(string ColourType, string VehicleType);
    }
}
