using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using BA.Lesson16.AP.Lab1;
using BA.Lesson16.AP.Lesson1;
using BA.Lesson16.AP.Lesson2;
using BA.Lesson16.AP.Lesson3;

namespace BA.Lesson16.AP
{
    class Program
    {


        static void Main(string[] args) {

            Lesson3();

            //Lesson2();
            //FirstThreadExample.ThreadExample();
            //FirstThreadExample.SemaphoreMethod();
            //Lab1();
            //Console.WriteLine("Exit");
            Console.ReadLine();
        }

        private static void Lesson3() {
            //CHECKTHAT!!!!!!!!!!! MutexExample.DoWork();
            Console.WriteLine($"Main thread id#{Thread.CurrentThread.ManagedThreadId}");
            //TaskExample.DoColdTask();
            //TaskExample.DoHotTask();
            //TaskExample.DoTaskWithContinuation();
            //TaskExample.DoTaskWithCatchingException();
            /*var task = TaskExample.DivideAsync(5, 3);
            Console.WriteLine(task.Result);*/

            CancellationTokenSource cts = new CancellationTokenSource();
            Task.Run(()=> {
                Thread.Sleep(3000);
                cts.Cancel();
            });

            TaskExample.CalculateWithCancellation(cts.Token);
            cts.Cancel();



        }

        private static void Lesson2() {

            Console.WriteLine($"Main Thread #{Thread.CurrentThread.ManagedThreadId} ");
            /*MonitorExample monitorExample = new MonitorExample();
            monitorExample.DoWork();*/

            /*AutoResetEventExample autoResetEventExample = new AutoResetEventExample();
            autoResetEventExample.DoWork();*/

            /*InterlockExample interlockExample = new InterlockExample();
            interlockExample.DoWork();*/

            /*SynchronizationAttributeExample synchronizationAttributeExample = new SynchronizationAttributeExample();
            //synchronizationAttributeExample.DoWork();
            synchronizationAttributeExample.DoWorkMinus();*/

            /*ThreadPoolExample threadPoolExample = new ThreadPoolExample();
            threadPoolExample.DoWork();*/

            APMExample aPMExample = new APMExample();
            aPMExample.ReadFile();

        }

        private static void Lab1() {
            new FirstThreadLab().Run();
        }


    }
}
