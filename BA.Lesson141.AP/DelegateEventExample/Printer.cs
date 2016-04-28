using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson141.AP.DelegateEventExample
{
    static class Printer
    {
        //internal static void MessageEventHandler(object sender, string message) {
        internal static void MessageEventHandler(object sender, MessageReseivedEventArgs e) {
            //Console.WriteLine($"Printer. sender: {sender}, message: {message}");
            Console.WriteLine($"Printer. sender: {sender}, message: {e.Message}");
        }
    }
}
