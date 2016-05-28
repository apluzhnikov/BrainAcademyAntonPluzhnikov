using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.SingletonExample
{
    static class Singleton
    {
        public static void Run() {
            SimpleSingleton SimpleSingleton = SimpleSingleton.Instance;
            SimpleSingleton SimpleSingleton1 = SimpleSingleton.Instance;
            SimpleSingleton SimpleSingleton2 = SimpleSingleton.Instance;
            SimpleLazySingleton SimpleLazySingleton = SimpleLazySingleton.Instance;
            SimpleLazySingleton SimpleLazySingleton1 = SimpleLazySingleton.Instance;
            SimpleLazySingleton SimpleLazySingleton2 = SimpleLazySingleton.Instance;
        }
    }
}
