using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.StructuralPatterns.AdapterExample.Adaptee
{
    enum LogType
    {
        Error,
        Warning,
        Debug
    }
    class DBLogger
    {
        public void Log(string message, LogType logType) {
            Console.WriteLine($"{message} , logtype: {logType}");
        }
    }
}
