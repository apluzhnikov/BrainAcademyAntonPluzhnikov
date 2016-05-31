using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.StructuralPatterns.AdapterExample.Adaptee
{
    class FileLogger
    {
        string _pathFile = "c:\\test.txt";

        public void LogError(string message) {
            Console.WriteLine($"Message: { message } write to: {_pathFile}");
        }

    }
}
