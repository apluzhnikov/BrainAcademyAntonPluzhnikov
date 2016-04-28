using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson131.AP.Animal
{
    interface IBird
    {
        string Name { get; }
        double MaxSpeed { get; }
        double CurrentSpeed { get; set; }

        void FlyWithinWind(double windSpeed);
    }
}
