using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BA.Lesson16.AP.Lesson2
{
    [Synchronization]//thread safety
    class SynchronizationAttributeExample : ContextBoundObject
    {
        public void DoWork() {
            for (int i = 0; i < 5; i++)
            {
                Thread thread = new Thread(Print) { Name = $"Thread #{i}", IsBackground = false };
                thread.Start();
            }

        }


        public void Print() {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Thread id{Thread.CurrentThread.ManagedThreadId} name: {Thread.CurrentThread.Name} reads {i}");
                Thread.Sleep(500);
            }

        }


        public void DoWorkMinus() {
            for (int i = 0; i < 100; i++)
            {
                Thread thread = new Thread(PrintMinus) { Name = $"Thread #{i}", IsBackground = false };
                thread.Start();
            }
            Console.WriteLine(_x);
        }

        int _x = 1000;

        void PrintMinus() {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"thread name:{Thread.CurrentThread.Name} value:  {_x}");
                _x--;
            }

        }
    }
}
