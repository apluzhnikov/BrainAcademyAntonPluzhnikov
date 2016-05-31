using PATTERNS.StructuralPatterns.AdapterExample.Adaptee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.StructuralPatterns.AdapterExample
{
    class FileLoggerAdapter : ILogger
    {
        FileLogger _fileLogger = new FileLogger();
        public void WriteError(Exception e, string message) {
            _fileLogger.LogError($"{ message}. {e.ToString()}");
        }
    }
}
