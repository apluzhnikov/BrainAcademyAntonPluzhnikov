using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18.lesson2
{
    class ZoneEvidenceExample
    {
        public void DoWork() {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Zone zone = assembly.Evidence.GetHostEvidence<Zone>();
            Console.WriteLine($"Zone: {zone.SecurityZone.ToString()}");
            Console.WriteLine($"Trusted? : {assembly.IsFullyTrusted}");
        }
    }
}
