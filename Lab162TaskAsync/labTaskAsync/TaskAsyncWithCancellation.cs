using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab162TaskAsync.labTaskAsync
{
    static class TaskAsyncWithCancellation
    {
        static public async Task<double> MultiplyAsync(double a, double b, CancellationToken cancellationToken)
        {
            //return await Task.Run(() => Multiply(a, b, cancellationToken), cancellationToken);

            /*return await Task.Run(
                () =>
                {
                    cancellationToken.ThrowIfCancellationRequested();
                    return Multiply(a, b);
                }
                , cancellationToken);*/

            return await Task.Factory.StartNew(
                () => 
                {
                    cancellationToken.ThrowIfCancellationRequested();
                    return Multiply(a, b);
                }
                , cancellationToken);

        }

        static public double Multiply(double a, double b)
        {
            Thread.Sleep(200);            
            return a * b;
        }

    }
}
