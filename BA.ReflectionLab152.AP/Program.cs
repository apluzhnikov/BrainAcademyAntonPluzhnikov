using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BA.ReflectionLab152.AP
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFrom(@"F:\ReflectionLabSources.dll");


            Console.WriteLine("Types:");
            foreach (var type in assembly.DefinedTypes)
            {
                Console.WriteLine($"Type: {type.ToString()}");
                if (type.BaseType != null)
                    Console.WriteLine($"BaseType: {type.BaseType.ToString()}");
                
            }

            

            Console.ReadLine();

        }
    }
}
