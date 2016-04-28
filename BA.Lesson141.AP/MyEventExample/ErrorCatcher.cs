using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson141.AP.MyEventExample
{
    static class ErrorCatcher
    {
        internal static void ErrorReceivedEventHandler(object sender, MyEventArgs e) {
            if (!string.IsNullOrWhiteSpace(e.Error))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Error);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
