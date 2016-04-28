using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APLAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello Anton, it's your first lab here! Please press 'Enter' to see your next message");
            //Console.ReadLine();
            //var message = "You are now in a debug regime. Please press 'Enter to exit from this app'";

            //var composeMessge = "Here is a composed message -> ";
            //Console.WriteLine(composeMessge);



            /*string sampleStringVariable = "Academy";
            char sampleCharVariable = 'c';
            int sampleIntVariable = 2;
            double sampleDoubleVariable = 19.9;

            int intval = int.MaxValue - 100;

            short shortval = (short)intval;
            Console.WriteLine(shortval);

            var toConsole = string.Format("String: {0}\r\nChar: {1}\r\nInt: {2}\r\nDouble: {3}", sampleStringVariable, sampleCharVariable, sampleIntVariable, sampleDoubleVariable);
            Console.WriteLine(toConsole);*/

            int switchVar = 1;
            switch (switchVar)
            {
                case 1:
                    switchVar++;
                    break;
                case 2:
                    switchVar--;
                    break;
                default :
                    break;
            }

            //ask about limit for foreach


            Console.ReadLine();
        }
    }
}
