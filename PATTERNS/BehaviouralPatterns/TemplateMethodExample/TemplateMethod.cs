using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.BehaviouralPatterns.TemplateMethodExample
{
    static class TemplateMethod
    {
        public static void Run() {
            var inputManager = new FlightConsoleInputManager();
            //InputManager<Flight> inputManager = new FlightConsoleInputManager();

            Flight flight = null;
            do
            {
                try {
                    flight = inputManager.Create();
                    Console.WriteLine($"Flight info {flight}");
                }
                catch(OperationCanceledException e)
                {
                    Console.WriteLine($"Sucker!!!, {e.Message}");
                    break;
                }
                catch(InvalidOperationException e)
                {
                    Console.WriteLine($"Bad hands!!!, {e.Message}");
                }
            } while (flight == null);
        }
    }
}
