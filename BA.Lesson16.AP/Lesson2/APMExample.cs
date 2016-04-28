using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BA.Lesson16.AP.Lesson2
{
    delegate int MyDelegate();

    class APMExample
    {
        public void ReadFile() {

            /*MyDelegate myDelegate = new MyDelegate();
            myDelegate.BeginInvoke*/

            byte[] buffer = null;
            using (FileStream fs = File.OpenRead(@"d:\Flights.xml"))
            {
                buffer = new byte[fs.Length];
                var asyncResult = fs.BeginRead(buffer, 0, buffer.Length, AsyncCallbackHandler, null);
                while (!asyncResult.IsCompleted)
                {                    
                    DoWork(string.Empty);
                }
                var countBytesRead = fs.EndRead(asyncResult);

                Console.WriteLine($"count bytes read {countBytesRead}");
                Console.WriteLine();
                Console.WriteLine($"buffer: {BitConverter.ToString(buffer)}");
            }
        }


        void AsyncCallbackHandler(IAsyncResult ar) {
            Console.WriteLine("Finished reading");
            //Console.WriteLine($"Thread{}");
        }

        public void DoWork(object state) {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Do some work in thread {Thread.CurrentThread.ManagedThreadId} value: {i}");
            }
        }
    }
}
