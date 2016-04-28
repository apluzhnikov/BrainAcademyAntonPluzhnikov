using BA.Lesson131.AP.Animal;
using BA.Lesson131.AP.Animal.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson131.AP.Models.Animal
{
    abstract class Bird : IBird
    {
        public double CurrentSpeed { get; set; }

        public abstract double MaxSpeed { get; }

        public string Name { get { return GetType().Name; } }

        public virtual void FlyWithinWind(double windSpeed) {
            var currentSpeed = CurrentSpeed + windSpeed;
            if (currentSpeed > MaxSpeed)
            {
                var message = string.Format("{0} achieved the speed {1}, it's {2} km/h bigger than max speed", Name, currentSpeed, Math.Abs(MaxSpeed - currentSpeed));
                throw new BirdFlewAwayException(message, BirdState.Dead);
            }
        }
    }
}
