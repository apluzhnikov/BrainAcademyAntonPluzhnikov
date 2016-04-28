using Lab162TaskAsync.labTaskAsync;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab162TaskAsync
{
    class Program
    {
        static void Main(string[] args)
        {

            TradeSimulator.StartSelling();
            
            //TaskAsyncWithCancellationRun();
            Console.ReadLine();
        }

        private static void TaskAsyncWithCancellationRun()
        {
            double a = 1.1;
            double b = a;

            var cts = new CancellationTokenSource();

            var task = TaskAsyncWithCancellation.MultiplyAsync(a, b, cts.Token);

            Task.Run(() =>
            {
                Thread.Sleep(1000);
                cts.Cancel();
            });



            task.ContinueWith(
                async (task1) =>
                {
                    var taskResult = task.Result;
                    while (true)
                    {
                        taskResult = await TaskAsyncWithCancellation.MultiplyAsync(taskResult, taskResult, cts.Token);
                        Console.WriteLine($"taskResult: { taskResult}");
                    }

                }, TaskContinuationOptions.OnlyOnRanToCompletion
                ).ContinueWith(
                (task1) =>
                {
                    Console.WriteLine("Operation was canceled!");
                }, TaskContinuationOptions.OnlyOnCanceled
            );

        }
    }
}
