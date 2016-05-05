using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18.lesson1
{
    static class PointerExample
    {
        static unsafe public void DoWork() {
            int a = 10;
            int* ptr = &a;

            Console.WriteLine($"Value: { *ptr }");
            Console.WriteLine("Address: {0:X}", (int)ptr);

            Console.WriteLine($"ToString: { ptr->ToString()}");
            Console.WriteLine($"Size of int: { sizeof(int) }");
            Console.WriteLine($"Size of float: { sizeof(float) }");
            Console.WriteLine($"Size of double: { sizeof(double) }");
        }

        static unsafe public void DoWorkWithArray() {
            double[] arr = new double[5] { 2.4, 1.5, 3.1, 4.4, 10.3 };

            //double[] arr = null;

            fixed (double* heapArrPtr = arr)
            //fixed (double* heapArrPtr = &arr[0])
            {

                *(heapArrPtr + 6) = 4;

                Console.WriteLine($"heapArrPtr: {*heapArrPtr}");
                Console.WriteLine($"heapArrPtr + 1: {*(heapArrPtr + 1)}");
                //Console.WriteLine($"heapArrPtr + 2: {*(heapArrPtr + 2)}");
                Console.WriteLine($"heapArrPtr + 3: {*(heapArrPtr + 3)}");
                Console.WriteLine($"heapArrPtr + 4: {*(heapArrPtr + 4)}");

                Console.WriteLine($"heapArrPtr + 5: {*(heapArrPtr + 5)}");
                Console.WriteLine($"heapArrPtr + 6: {*(heapArrPtr + 6)}");
                Console.WriteLine($"heapArrPtr + 7: {*(heapArrPtr + 7)}");
                Console.WriteLine($"heapArrPtr + 8: {*(heapArrPtr + 8)}");
                Console.WriteLine($"heapArrPtr + 9: {*(heapArrPtr + 9)}");
            }
        }

        static unsafe public void DoWorkWithStack() {
            double* stackArrPtr = stackalloc double[5];
            for (int i = 0; i < 5; i++)
            {
                *(stackArrPtr + i) = i * 3;
                Console.WriteLine($"stackArrPtr + i: { *(stackArrPtr + i)}");
            }
        }

        static unsafe public void DoWorkWithPointersArray() {

            double b = 10.5;
            double c = 1.3;

            double*[] arrPtr = new double*[] { &b, &c };

            *arrPtr[1] = 11.5;

            for (int i = 0; i < arrPtr.Length; i++)
            {
                Console.WriteLine($"arrPtr[{i}]: {*arrPtr[i]}");
            }

        }

        static public void DoWorkWithNullableTypes() {
            int? tmp = null;
            int? tmp3 = null;
            var tmp2 = tmp ?? tmp3 ?? 4;
            Console.WriteLine($"tmp2: {tmp2}");
        }


    }
}
