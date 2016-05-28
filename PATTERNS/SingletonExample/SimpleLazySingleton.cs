using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.SingletonExample
{
    class SimpleLazySingleton
    {
        static volatile SimpleLazySingleton s_instance;
        static object s_locker = new object();

        private SimpleLazySingleton() { }

        public static SimpleLazySingleton Instance {
            get {
                if (s_instance == null)
                    lock (s_locker)
                    {
                        if (s_instance == null)
                            s_instance = new SimpleLazySingleton();

                    }

                Console.WriteLine($"SimpleLazySingleton's hash code { s_instance.GetHashCode() }");
                return s_instance;
            }
        }
    }
}
