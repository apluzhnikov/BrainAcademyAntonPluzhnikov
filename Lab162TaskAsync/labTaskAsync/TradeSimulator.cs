using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab162TaskAsync.labTaskAsync
{
    static class TradeSimulator
    {

        static public void StartSelling()
        {
            


            var taskFruit = new Task(
                () =>
                {
                    int start = 0;
                    const int end = 10;
                    while (++start <= end)
                    {
                        SellFruit();                        
                    }
                }); 

            var taskVegitable = new Task(
                () =>
                {
                    int start = 0;
                    const int end = 10;
                    while (++start <= end)
                    {
                        SellVegetable();
                    }
                });

            taskFruit.Start();
            taskVegitable.Start();

            Task.WaitAll(taskFruit, taskVegitable);
            Console.WriteLine("FRUIT/VEGETABLE was sold");

            /*while (++start <= end)
            {
                if (start % 2 == 0)
                    Task.Factory.StartNew(() => SellFruit()).
                        ContinueWith
                        (
                        (obj) => Console.WriteLine("Fruit was sold")
                        );
                else
                    Task.Factory.StartNew(() => SellVegetable()).
                        ContinueWith
                        (
                        (obj) => Console.WriteLine("Vegitable was sold")
                        ); ;
            }

            Task.WaitAll();
            Console.WriteLine("FRUIT/VEGETABLE was sold");*/

        }


        static Random rand = new Random();
        static private void SellFruit()
        {
            Thread.Sleep(200);
            Console.WriteLine("Fruit was sold");
        }

        static private void SellVegetable()
        {
            Thread.Sleep(500);
            Console.WriteLine("Vegitable was sold");
        }

    }
}
