using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.StructuralPatterns.DecoratorExample
{
    class StorageAgentLogDecorator : IStorageAgent
    {
        IStorageAgent _storageAgent;
        public StorageAgentLogDecorator(IStorageAgent storageAgent) {
            _storageAgent = storageAgent;
        }
        public void Save(string message) {
            Console.WriteLine("start saving");
            _storageAgent.Save(message);
            Console.WriteLine("end saving");
        }
    }
}
