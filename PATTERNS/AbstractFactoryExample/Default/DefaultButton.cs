using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.AbstractFactoryExample.Default
{
    class DefaultButton : IButton
    {
        public void Draw() {
            Console.WriteLine("Default button was drown");
        }
    }
}
