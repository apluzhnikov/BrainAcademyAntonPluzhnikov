using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18.lesson1.lab1
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MyPointerStruct
    {
        public int Id;
        public int Year;
        public double Salary;
    }

    static class StructPointerLab
    {
        static public unsafe void DoStructWork() {
            var myPointerStruct = new MyPointerStruct() { Id = 33, Salary = 7777777, Year = 2016 };

            MyPointerStruct* myPointerStruct2 = &myPointerStruct;

            Console.WriteLine($"Size of MyPointerStruct: {sizeof(MyPointerStruct)}");
            Console.WriteLine($"===========before changes=========");
            Console.WriteLine($"Id: {myPointerStruct2->Id}");
            Console.WriteLine($"Salary: {myPointerStruct2->Salary}");
            Console.WriteLine($"Year: {myPointerStruct2->Year}");

            myPointerStruct2->Year = 2004;

            Console.WriteLine($"===========after changes=========");
            Console.WriteLine($"Id: {myPointerStruct2->Id}");
            Console.WriteLine($"Salary: {myPointerStruct2->Salary}");
            Console.WriteLine($"Year: {myPointerStruct2->Year}");

            /*Console.WriteLine($"Id: {myPointerStruct2[0].Id}");
            Console.WriteLine($"Salary: {myPointerStruct2[0].Salary}");
            Console.WriteLine($"Year: {myPointerStruct2[0].Year}");

            Console.WriteLine($"field1: {(*(myPointerStruct2)).Id}");
            Console.WriteLine($"field2: {(*(myPointerStruct2)).Salary}");
            Console.WriteLine($"field3: {(*(myPointerStruct2)).Year}");*/

            /*Console.WriteLine($"field3: {*(myPointerStruct2 + 0)}");
            Console.WriteLine($"field3: {*(myPointerStruct2 + 1)}");
            Console.WriteLine($"field3: {*(myPointerStruct2 + 2)}");*/
        }
    }
}
