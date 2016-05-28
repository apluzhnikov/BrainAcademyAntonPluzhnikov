using PATTERNS.AbstractFactoryExample;
using PATTERNS.SingletonExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("--------------------------AbstractFactory----------------------------");
            AbstractFactory.Run();
            Console.WriteLine("--------------------------END----------------------------");

            Console.WriteLine("--------------------------Singleton----------------------------");
            Singleton.Run();
            Console.WriteLine("--------------------------END----------------------------");

            Console.ReadLine();
        }
    }
}
