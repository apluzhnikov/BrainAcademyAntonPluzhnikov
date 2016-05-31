using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.StructuralPatterns.AdapterExample
{        
    static class Adapter
    {
        static void DoWork(string name) {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));
        }
        public static void Run() {
            //ILogger logger = new FileLoggerAdapter();
            ILogger logger = new DBLoggerAdapter();
            try
            {
                DoWork(null);
            }
            catch(Exception e)
            {
                logger.WriteError(e, "wrong data was transferred");
            }
        }
    }
}
