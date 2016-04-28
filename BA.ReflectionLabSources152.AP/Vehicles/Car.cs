using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.ReflectionLabSources152.AP.Vehicles
{
    abstract class Car : ICar
    {

        public double FuelLevel { get; set; }

        public abstract string Name { get; }

        public virtual double TankCapacity {
            get {
                return 20.0;                
            }
        }

        public virtual void Start() {
            if(FuelLevel == 0)
            {
                Console.WriteLine("Not enough fuel for start");
                return;
            }
            Console.WriteLine("Drive!");
        }
    }
}
