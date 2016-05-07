using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18.lesson2
{
    class PrincipalPolicyExample
    {
        public static void DoWork() {
            AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
            PrincipalPermission principalPermission = new PrincipalPermission(null,"Administrators");
            principalPermission.Demand();
            Console.WriteLine("Demand successfull");
        }


    }
}
