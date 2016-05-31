using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.StructuralPatterns.DecoratorExample
{
    static class Decorator
    {
        public static void Run() {
            IStorageAgent storageAgent = new StorageAgentLogDecorator(new StorageAgentDurationDecorator(new StorageAgent()));
            storageAgent.Save("Hello World!");
        }
    }
}
