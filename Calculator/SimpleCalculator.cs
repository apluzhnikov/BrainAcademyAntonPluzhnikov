using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SimpleCalculator
    {

        public double Add(double first, double second) => first + second;

        public double Sub(double first, double second) => first - second;

        public double Div(double first, double second) {
            if (second == 0)
                throw new DivideByZeroException();
            return first / second;
        }

        public double Mul(double first, double second) => first * second;
        }
}
