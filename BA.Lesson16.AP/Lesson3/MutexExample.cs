using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BA.Lesson16.AP.Lesson3
{

    static class MutexExample
    {

        static Mutex s_mutex = new Mutex(false, "BA.Lesson16.AP:71ba3d43-69a7-46bf-a335-ddaa2091aa0e");//put it to main file
        static public void DoWork() {
            if(!s_mutex.WaitOne(TimeSpan.FromSeconds(2), false))
            {
                Console.WriteLine("Another inctance of app has been launched");
                Console.ReadLine();
            }

            try
            {
                Console.WriteLine($"Main thread #{Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(5000);
            }
            finally
            {
                s_mutex.ReleaseMutex();
            }
            
        }
    }
}
