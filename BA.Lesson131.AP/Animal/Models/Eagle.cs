using BA.Lesson131.AP.Animal.Exceptions;
using BA.Lesson131.AP.Models.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson131.AP.Animal.Models
{
    sealed class Eagle : Bird
    {
        const double _maxSpeed = 70.30;
        const double _speedLeeway = 10;

        public override double MaxSpeed {
            get {
                return _maxSpeed;
            }
        }

        public override void FlyWithinWind(double windSpeed) {
            var currentSpeed = CurrentSpeed + windSpeed;
            if (currentSpeed > MaxSpeed)
            {
                var message = string.Format("{0} achieved the speed {1}, it's {2} km/h bigger than max speed", Name, currentSpeed, Math.Abs(MaxSpeed - currentSpeed));
                if (currentSpeed > MaxSpeed + _speedLeeway)
                    throw new BirdFlewAwayException(message, BirdState.Dead);
                else
                {
                    message += string.Format(", but the the speed leeway in {0} allowed this bird to survive", _speedLeeway);
                    throw new BirdFlewAwayException(message, BirdState.Alive);
                }
            }
        }
    }
}
