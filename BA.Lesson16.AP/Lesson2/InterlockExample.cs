using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BA.Lesson16.AP.Lesson2
{
    class InterlockExample
    {
        public void DoWork() {
            for (int i = 0; i < 100; i++)
            {
                Thread thread = new Thread(Print) { Name = $"Thread #{i}", IsBackground = false };
                thread.Start();
            }
            Thread.Sleep(1000);
            Console.WriteLine(_x);
        }

        int _x = 1000;

        void Print() {

            for (int i = 0; i < 10; i++)
            {
                Interlocked.Add(ref _x, -1);
                //_x--;
            }

        }
    }
}
