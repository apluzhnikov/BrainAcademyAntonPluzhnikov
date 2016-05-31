using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.StructuralPatterns.DecoratorExample
{
    class StorageAgent : IStorageAgent
    {
        public void Save(string message) {
            Console.WriteLine($"message: '{message}' will be saved to the DB");
        }
    }
}
