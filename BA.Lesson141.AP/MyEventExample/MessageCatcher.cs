using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson141.AP.MyEventExample
{
    class MessageCatcher
    {
        internal static void MessageReceivingEventHandler(object sender, MyEventArgs e) {
            Console.Beep();
        }

        internal static void MessageReceivedEventHandler(object sender, MyEventArgs e) {
            if (!string.IsNullOrWhiteSpace(e.Message))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Saved");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
