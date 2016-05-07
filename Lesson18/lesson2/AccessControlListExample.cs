using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18.lesson2
{
    class AccessControlListExample
    {
        public static void ReadACL() {
            using (var fileStream = File.Open(@"d:\Flights.csv", FileMode.Open))
            {
                var fileSecurity = fileStream.GetAccessControl();
                //var rules = fileSecurity.GetAccessRules(true, true, typeof(NTAccount));
                var rules = fileSecurity.GetAccessRules(true, true, typeof(SecurityIdentifier));

                foreach (var rule in rules)
                {
                    var fileRule = rule as FileSystemAccessRule;
                    Console.WriteLine($"Access type: {fileRule.AccessControlType}");
                    Console.WriteLine($"Rights: {fileRule.FileSystemRights}");
                    Console.WriteLine($"Identity: {fileRule.IdentityReference}");

                    Console.WriteLine();
                }
            }
            
        }
    }
}
