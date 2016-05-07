using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BA.Lesson16.AP.Lesson3
{
    static class TaskExample
    {

        public static Task<double> DivideAsync(double a, double b) {            
            return Task.Run(()=>Divide(a,b));
        }

        public static async Task<double> DivideTaskAsync(double a, double b) {
            var result = await Task.Run(() => Divide(a, b));
            Console.WriteLine($"Result in task async { result}");
            return result;
        }

        static public void DoHotTask() {

            var task = Task.Run(() => Divide(5, 2));
            var task2 = Task.Factory.StartNew(() => Divide(5, 3));


            TaskFactory tf = new TaskFactory();

            var task3 = tf.StartNew(() => Divide(5, 3.3));
            var task4 = tf.StartNew(() => Divide(5, 4));


            Console.WriteLine($"result1: {task.Result}");
            Console.WriteLine($"result2: {task2.Result}");
            Console.WriteLine($"result3: {task3.Result}");
            Console.WriteLine($"result4: {task4.Result}");

            //task.Dispose();
            //task2.Dispose();
        }

        public static void DoTaskWithCatchingException() {
            var task1 = Task.Factory.StartNew(() => Divide(5, 3))
                .ContinueWith
                (
                    task =>
                    {
                        var result = Divide(5, 0);
                        Console.WriteLine($"result {result}");
                    }
                );

            var continuation = task1
                .ContinueWith
                (
                    task => Console.WriteLine("Task was faulted"),
                    TaskContinuationOptions.OnlyOnFaulted
                );
            try {
                task1.Wait();
            }
            catch(AggregateException ex)
            {
                Console.WriteLine(ex);
            }
        }

        internal static void CalculateWithCancellation(CancellationToken token) {            
            var task = Task.Factory
                .StartNew
                (

                    ()=> {
                        double sum = 0;
                        int counter = 0;
                        while (++counter < 10)
                        {
                            token.ThrowIfCancellationRequested();
                            sum += Divide(10 , 2);
                        }
                        return sum;
                    }
                , token);

            double result=0;

            try
            {
                result = task.Result;
            }
            catch(OperationCanceledException ex) {
                Console.WriteLine("OperationCanceledException");
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("AggregateException");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception");
            }
        }

        public static void DoTaskWithContinuation() {
            var task1 = Task.Factory.StartNew(() => Divide(5, 2));

            /*var continuationTask = task1.ContinueWith(task => Divide(task.Result, 2));
            //above equals to below!!!!!!!!!!!!!!!!!!
            var continuationTask1 = task1.ContinueWith(Tmp);*/

            var continuationTask = task1.ContinueWith
            (
                task =>
                {
                    var result = Divide(task.Result, 3);
                    Console.WriteLine($"Result in continuation: {result}");
                    return result;//if we return something, then continuationTask will have a resulr property, if do not return, then no result property
                },
                TaskContinuationOptions.OnlyOnRanToCompletion
            );

            var continuationTask2 = task1.ContinueWith
            (
                task =>
                {
                    var result = Divide(task.Result, 0);
                    Console.WriteLine($"Result in continuation: {result}");
                    return result;//if we return something, then continuationTask will have a resulr property, if do not return, then no result property
                },
                TaskContinuationOptions.OnlyOnRanToCompletion
            );

            var continuationTask3 = task1.ContinueWith
            (
                //task => Divide(task.Result, 3),
                (task) => Console.WriteLine("Task faulted!"),
                TaskContinuationOptions.OnlyOnFaulted
            );

        }

        static double Tmp(Task<double> task) {
            return Divide(task.Result, 2);
        }


        static public void DoColdTask() {
            var task = new Task<double>(() => Divide(5, 2));
            var task2 = new Task<double>(() => Divide(5, 3));
            task.Start();
            task2.Start();

            //Task.WaitAll(task, task2);

            Console.WriteLine($"result: {task.Result}");
            Console.WriteLine($"result: {task2.Result}");

            task.Dispose();
            task2.Dispose();
        }

        static double Divide(double a, double b) {
            if (b == 0)
                throw new ArgumentException();

            Thread.Sleep(2000);

            Console.WriteLine($"Task id#{Task.CurrentId}. Thread id#{Thread.CurrentThread.ManagedThreadId}");
            return a / b;
        }
    }
}
