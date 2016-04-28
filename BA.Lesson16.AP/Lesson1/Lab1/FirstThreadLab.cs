using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BA.Lesson16.AP.Lab1
{
    class FirstThreadLab
    {
        /*
        IMPLEMENT: 
        1) for sending a message you need to spend 3 seconds.
        2) run a new thread if there are messages to send left.

        */

        static Queue<string> _names = new Queue<string>();

        Thread background = new Thread(Print);

        internal void Run() {

            background.Start();

            var name = string.Empty;
            while (true)
            {
                name = Console.ReadLine();
                if (name.Equals("exit", StringComparison.InvariantCultureIgnoreCase))
                {
                    background.Abort();
                    break;
                }

                if (!string.IsNullOrWhiteSpace(name))
                    _names.Enqueue(name);
            }
        }

        private static void Print() {
            while (true)
            {
                if (_names.Count > 0)
                {
                    Console.WriteLine();
                    var messagesCount = _names.Count;
                    while (_names.Count > 0)
                    {
                        Console.WriteLine("Sent to: {0}", _names.Dequeue());
                    }
                    Console.WriteLine("{0} messages has been sent", messagesCount);
                }else
                    Console.WriteLine("0 messages has been sent");
                Thread.Sleep(5000);
            }
        }

    }
}
