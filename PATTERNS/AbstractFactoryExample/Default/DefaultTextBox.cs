using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.AbstractFactoryExample.Default
{
    class DefaultTextBox : ITextBox
    {
        public void Draw() {
            Console.WriteLine("Default textbox was drown");
        }
    }
}
