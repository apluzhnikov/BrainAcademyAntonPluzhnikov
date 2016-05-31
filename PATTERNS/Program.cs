using PATTERNS.AbstractFactoryExample;
using PATTERNS.BehaviouralPatterns.StrategyExample;
using PATTERNS.BehaviouralPatterns.TemplateMethodExample;
using PATTERNS.BehaviouralPatterns.VisitorExample;
using PATTERNS.BuilderExample;
using PATTERNS.SingletonExample;
using PATTERNS.StructuralPatterns.AdapterExample;
using PATTERNS.StructuralPatterns.DecoratorExample;
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
            Console.WriteLine();

            Console.WriteLine("--------------------------Singleton----------------------------");
            Singleton.Run();
            Console.WriteLine("--------------------------END----------------------------");
            Console.WriteLine();

            Console.WriteLine("--------------------------Builder----------------------------");
            BuilderExampleTest.Run();
            Console.WriteLine("--------------------------END----------------------------");
            Console.WriteLine();

            Console.WriteLine("--------------------------Adapter----------------------------");
            Adapter.Run();
            Console.WriteLine("--------------------------END----------------------------");
            Console.WriteLine();

            Console.WriteLine("--------------------------Decorator----------------------------");
            Decorator.Run();
            Console.WriteLine("--------------------------END----------------------------");
            Console.WriteLine();

            Console.WriteLine("--------------------------Strategy----------------------------");
            Strategy.Run();
            Console.WriteLine("--------------------------END----------------------------");
            Console.WriteLine();

            Console.WriteLine("--------------------------TemplateMethod----------------------------");
            TemplateMethod.Run();
            Console.WriteLine("--------------------------END----------------------------");
            Console.WriteLine();

            Console.WriteLine("--------------------------Visitor----------------------------");
            Visitor.Run();
            Console.WriteLine("--------------------------END----------------------------");
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
