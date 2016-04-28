using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson141.AP.DelegateLikeEventExample
{
    class ConsolePrinter
    {
        internal static void MessageEventHandler(object sender, string message) {
            Console.WriteLine($"ConsolePrinter. sender: {sender}, message: {message}");
        }

    }
}
