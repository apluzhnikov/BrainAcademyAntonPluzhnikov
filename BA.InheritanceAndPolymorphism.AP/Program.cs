using BA.InheritanceAndPolymorphism.AP.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.InheritanceAndPolymorphism.AP
{
    class Program
    {
        static void Main(string[] args) {
            GasStation gasStation = new GasStation();
            ICar[] cars = new ICar[]
            {
                new Van(),
                new Motobike(),
                new PassangerCar()
            };

            Console.WriteLine("Enter fuel level to fill the Vehicles");
            int fuelLevel = 0;
            if (int.TryParse(Console.ReadLine(), out fuelLevel))
            {
                foreach (ICar car in cars)
                {
                    Van van = car as Van;//in this case will have null if not van
                    //Van van2 = (Van)car;//in this case will have an exception if not van

                    if (van != null)
                    {
                        van.Say("Hello");
                    }

                    gasStation.FillFuel(car, fuelLevel);
                    car.Start();
                }
            }
            
            Console.ReadLine();

        }
    }
}
