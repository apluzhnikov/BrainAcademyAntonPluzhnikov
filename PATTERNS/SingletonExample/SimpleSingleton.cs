using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.SingletonExample
{
    class SimpleSingleton
    {
        readonly static SimpleSingleton s_instance = new SimpleSingleton();

        private SimpleSingleton() {
        }

        public static SimpleSingleton Instance {
            get {
                Console.WriteLine($"SimpleSingleton's hash code { s_instance.GetHashCode() }");
                return s_instance;
            }
        }
    }
}
