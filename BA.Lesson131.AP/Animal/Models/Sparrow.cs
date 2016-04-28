using BA.Lesson131.AP.Models.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson131.AP.Animal.Models
{
    sealed class Sparrow : Bird
    {
        const double _maxSpeed = 30.4;

        public override double MaxSpeed {
            get {
                return _maxSpeed;
            }
        }
    }
}
