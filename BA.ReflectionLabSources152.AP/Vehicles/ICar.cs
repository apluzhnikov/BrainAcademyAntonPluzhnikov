using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.ReflectionLabSources152.AP.Vehicles
{
    interface ICar
    {
        string Name { get; }

        double FuelLevel { get; set; }

        double TankCapacity { get; }

        void Start();
    }
}
