using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BA.Lesson16.AP.Lesson1
{
    static class FirstThreadExample
    {
        static int _x, _y;

        static readonly object _locker = new object();

        public static void ThreadExample() {
            //Thread worker = new Thread(Background);
            //worker.Start("x");
            //Background("y");


            /*//threading pool
            WaitCallback clb = new WaitCallback(Background);
            ThreadPool.QueueUserWorkItem(clb, "x");
            ThreadPool.QueueUserWorkItem(clb, "Y");
            ThreadPool.QueueUserWorkItem(clb, "z");*/

            //_x = 20; _y = 5;
            //new Thread(Go).Start();

            //_x = 4; _y = 2;
            //new Thread(Go).Start();

            //SemaphoreMethod();

            Stopwatch sw = new Stopwatch();
            var sum = 0;
            var iteration = 100;
            sw.Start();
            for (int i = 0; i < iteration; i++)
            {
                sum += i;
                Thread.Sleep(100);
            }
            sw.Stop();
            Console.WriteLine("Parallelism Off. Sum is {0}, elapsed {1}", sum, sw.Elapsed);



            sw.Reset();
            sw.Start();
            sum = 0;

            Parallel.For(0, iteration, (i) =>
            {
                Thread.Sleep(100);
                //sum += i;
                Interlocked.Add(ref sum, i);

            });

            sw.Stop();
            Console.WriteLine("Parallelism On. Sum is {0}, elapsed {1}", sum, sw.Elapsed);

        }

        static SemaphoreSlim _sem = new SemaphoreSlim(3);
        public static void SemaphoreMethod() {

            for (int i = 0; i <= 5; i++)
            {
                new Thread(Enter).Start(i);
            }
        }

        private static void Enter(object id) {
            Console.WriteLine(id + " wants to enter");
            _sem.Wait();
            Console.WriteLine(id + " is in!");
            Thread.Sleep(1000 * (int)id);
            Console.WriteLine(id + " is leaving");
            _sem.Release();
        }

        static void Go() {
            if (_y != 0)
                Console.WriteLine(_x / _y);
            _y = 0;
        }


        static void Background(object data) {
            //var countInt = Convert.ToInt32(count);
            for (int i = 0; i < 10; i++)
            {
                lock (_locker)
                {
                    Console.Write(data);

                    Console.Write(Thread.CurrentThread.IsBackground);
                    Console.Write(Thread.CurrentThread.ManagedThreadId);
                    Console.WriteLine();
                }

            }
        }
    }
}
