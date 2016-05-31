using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.StructuralPatterns.AdapterExample
{
    interface ILogger
    {
        void WriteError(Exception e, string message);
    }
}
