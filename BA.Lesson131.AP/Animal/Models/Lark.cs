using BA.Lesson131.AP.Models.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson131.AP.Animal.Models
{
    sealed class Lark : Bird
    {
        const double _maxSpeed = 50;
        const double _chitingSpeed = 20;

        public override double MaxSpeed {
            get {
                return _maxSpeed + (IsHappy() ? _chitingSpeed : 0);
            }
        }

        Random rand = new Random((int)DateTime.Now.Ticks);

        private bool IsHappy() {
            if (rand.Next(0, 10) > 5)
                return true;
            return false;
        }
    }
}
