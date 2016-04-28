using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.ReflectionLabSources152.AP.Vehicles
{
    class PassangerCar : Car
    {
        public override string Name {
            get {
                return "Passanger car";
            }
        }

        public override double TankCapacity {
            get {
                return base.TankCapacity * 2.1;
            }
        }

    }
}
