using PATTERNS.BehaviouralPatterns.TemplateMethodExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.BehaviouralPatterns.TemplateMethodExample
{
    class FlightConsoleInputManager : InputManager<Flight>
    {
        protected override bool AskQuestion() {
            Console.WriteLine($"Do you wish to create a flight? (y/n)");
            var answer = Console.ReadLine();
            return answer.Equals("y");
        }
        protected override string ReadAnswer() {
            Console.WriteLine("Input flight info using '|' as a separator");
            return Console.ReadLine();
        }

        protected override bool IsValid(string responce) {
            var parameters = responce.Split('|');
            return parameters.Count() == 2;
        }

        protected override Flight CreateEntity(string responce) {
            var parameters = responce.Split('|');
            return new Flight(parameters[0], parameters[1]);
        }
    }
}
