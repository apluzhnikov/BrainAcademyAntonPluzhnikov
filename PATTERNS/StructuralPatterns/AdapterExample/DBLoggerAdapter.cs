using PATTERNS.StructuralPatterns.AdapterExample.Adaptee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.StructuralPatterns.AdapterExample
{
    class DBLoggerAdapter : ILogger
    {
        DBLogger _dBLogger = new DBLogger();
        public void WriteError(Exception e, string message) {
            _dBLogger.Log($"{ message}. {e.ToString() }. An error has been saved in to the DB", LogType.Error);
        }
    }
}
