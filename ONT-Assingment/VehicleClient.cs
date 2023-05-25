using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT_Assingment
{
    abstract class VehicleClient
    {
        public IChassis TheChassis { get; set; }
        public IShell TheShell { get; set; }
        public ITrim TheTrim { get; set; }
        public List<IWheel> TheWheels { get; set; }
        public VehicleAbstractFactory vehicleFactory { get; set; }
        public VehicleClient(VehicleAbstractFactory vehicle)
        {
            this.TheWheels = new List<IWheel>();
            this.vehicleFactory = vehicle;

            Console.WriteLine("Creating {0}", this.GetType().Name);
        }
        public virtual void AddShell()
        {
            Console.WriteLine("Adding Shell");
        }
        public virtual void AddChassis()
        {
            Console.WriteLine("Adding Chassis");
        }
        public virtual void AddTrim()
        {
            Console.WriteLine("Adding Interior Trim");
        }
        public virtual void AddWheel()
        {
            Console.WriteLine("Add a Wheel");

            foreach (IWheel Current in TheWheels)
                Console.WriteLine("- {0}", Current.GetType().Name);
        }

        public virtual void MakeLux1000()
        {
            Console.WriteLine("Lux1000 ");
        }
        public virtual void MakeMV500()
        {
            Console.WriteLine("MV500 ");
        }
    }
}
