using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BA.Lesson16.AP.Lesson2
{
    class AutoResetEventExample
    {
        AutoResetEvent _autoResetEvent = new AutoResetEvent(false);

        public void DoWork() {
            for (int i = 0; i < 5; i++)
            {
                Thread thread = new Thread(Print) { Name = $"Thread #{i}", IsBackground = false };
                thread.Start();
            }
            _autoResetEvent.Set();
        }
                
        void Print() {
            _autoResetEvent.WaitOne();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Thread id{Thread.CurrentThread.ManagedThreadId} name: {Thread.CurrentThread.Name} reads {i}");
                Thread.Sleep(500);
            }

        }
    }
}
