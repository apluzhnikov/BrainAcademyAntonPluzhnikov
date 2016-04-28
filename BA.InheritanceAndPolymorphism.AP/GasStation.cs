using BA.InheritanceAndPolymorphism.AP.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.InheritanceAndPolymorphism.AP
{
    class GasStation
    {
        public void FillFuel(ICar car, double fuel) {
            if (car == null)
            {
                Console.WriteLine("This car is broken");
                return;
            } 
            if(car.FuelLevel+fuel>car.TankCapacity)
            {
                Console.WriteLine($"Can't fill the {car.Name}, because limit {car.TankCapacity} has been achived ");
                return;
            }
            car.FuelLevel += fuel;
            Console.WriteLine("FuelLEvel after gas station: {0}", car.FuelLevel);
        }
    }
}
