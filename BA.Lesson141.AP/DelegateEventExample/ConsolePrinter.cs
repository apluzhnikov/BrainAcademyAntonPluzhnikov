using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson141.AP.DelegateEventExample
{
    class ConsolePrinter
    {
        //internal static void MessageEventHandler(object sender, string message) {
        internal static void MessageEventHandler(object sender, MessageReseivedEventArgs e) {
            //Console.WriteLine($"Printer. sender: {sender}, message: {message}");
            Console.WriteLine($"ConsolePrinter. sender: {sender}, message: {e.Message}");
        }

    }
}
