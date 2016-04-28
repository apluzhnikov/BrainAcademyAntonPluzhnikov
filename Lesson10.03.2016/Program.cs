using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10._03._2016
{
    class Program
    {
        static void Main(string[] args) {

            Car bmv = new Car()
            {
                HoursePower = 4300,
                //Name = "AUDI",
                Name = "BMW",
                Year = 2004
            };

            Car audi = new Car()
            {
                HoursePower = 400,
                Name = "AUDI",
                Year = 2004
            };


            if (bmv == audi)
                Console.WriteLine("Equal");
            else
                Console.WriteLine("NOT Equal");

            if (bmv > audi)
                Console.WriteLine("BMV  more powerful");
            else
                Console.WriteLine("Audi  more powerful");


            Console.WriteLine("Before upgrade {0}", bmv.HoursePower);
            bmv++;
            Console.WriteLine("After upgrade {0}", bmv.HoursePower);

            int intcar = (int)bmv;
            Console.WriteLine("int car {0}", intcar);
            double doublecar = bmv;
            Console.WriteLine("double car {0}", doublecar);

            double num1 = 4;
            double num2 = 4.3423235;
            double num3 = 334.2333;

            Console.WriteLine("{0}", num1);
            Console.WriteLine("{0:f}", num2);
            Console.WriteLine("{0:0.00}", num3);

            Console.WriteLine("car summary: {0}", bmv + audi);

            Console.ReadLine();

        }
    }
}
