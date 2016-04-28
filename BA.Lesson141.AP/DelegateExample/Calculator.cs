using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson141.AP.DelegateExample
{
    class Calculator
    {
        internal int Sum(int first, int second) {
            Console.WriteLine("Sum");
            return first + second;
        }

        internal int Sub(int first, int second) {
            Console.WriteLine("Sub");
            return first - second;
        }

        internal static int Mul(int first, int second) {
            Console.WriteLine("Mul");
            return first * second;
        }

        internal static int Div(int first, int second) {
            Console.WriteLine("Div");
            return first / second;
        }
    }
}
