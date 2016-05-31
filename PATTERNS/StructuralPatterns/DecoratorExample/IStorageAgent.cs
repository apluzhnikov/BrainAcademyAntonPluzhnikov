using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.StructuralPatterns.DecoratorExample
{
    interface IStorageAgent
    {
        void Save(string message);
    }
}
