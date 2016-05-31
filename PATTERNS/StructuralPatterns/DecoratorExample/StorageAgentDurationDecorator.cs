using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.StructuralPatterns.DecoratorExample
{
    class StorageAgentDurationDecorator : IStorageAgent
    {
        IStorageAgent _storageAgent;
        public StorageAgentDurationDecorator(IStorageAgent storageAgent) {
            _storageAgent = storageAgent;
        }

        public void Save(string message) {            
            _storageAgent.Save(message);
            Console.WriteLine("Duration 444");
        }


    }
}
