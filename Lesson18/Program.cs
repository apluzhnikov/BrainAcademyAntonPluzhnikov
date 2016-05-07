using Lesson18.lesson1;
using Lesson18.lesson1.lab1;
using Lesson18.lesson2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18
{
    class Program
    {
        static void Main(string[] args) {
            Lesson1();
            Lesson2();

            Console.ReadLine();
        }

        private static void Lesson2() {
            //SecurityExample.DoSecurityWork();
            /*ZoneEvidenceExample zoneEvidenceExample = new ZoneEvidenceExample();
            zoneEvidenceExample.DoWork();*/
            //PrincipalPolicyExample.DoWork();
            //AccessControlListExample.ReadACL();
            SandboxingExample.DoWork();
        }

        static void Lesson1() {
            //PointerExample.DoWork();
            //PointerExample.DoWorkWithArray();
            //PointerExample.DoWorkWithStack();
            //PointerExample.DoWorkWithPointersArray();
            //PointerExample.DoWorkWithNullableTypes();
            //PInvokeExample.DoWork();
            //StructPointerLab.DoStructWork();
        }
    }
}
