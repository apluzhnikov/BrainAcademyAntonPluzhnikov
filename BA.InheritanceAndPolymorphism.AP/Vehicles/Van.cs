using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.InheritanceAndPolymorphism.AP.Vehicles
{
    sealed class Van : Car
    {
        public override string Name {
            get {
                return "Van";
            }
        }

        public override double TankCapacity {
            get {
                return 200.2;
            }
        }

        public void Say(string message) {
            Console.WriteLine("{0} to Van drivers", message);
        }
    }
}
