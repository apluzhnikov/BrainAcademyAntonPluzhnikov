using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson141.AP.GenericsAndExceptions
{
    class GenericsAndExceptionsExample
    {

        public GenericsAndExceptionsExample() {
            try
            {
                var str = Console.ReadLine();
                DoWorkFirstPart(!string.IsNullOrWhiteSpace(str) ? str : null);
            }
            catch (Exception e)
            {
                //FormatException foundFormatException = (FormatException)FindInnerException(e, typeof(FormatException));
                //DivideByZeroException foundDivideByZeroException = (DivideByZeroException)FindInnerException(e, typeof(DivideByZeroException));
                DivideByZeroException foundDivideByZeroException = FindInnerException<DivideByZeroException>(e);
                /*if (foundFormatException != null)
                    FormatExceptionHandler(foundFormatException);*/
                if (foundDivideByZeroException != null)
                    DivideByZeroExceptionHandler(foundDivideByZeroException);
                else
                    ExceptionHandler(e);
            }
        }


        private T FindInnerException<T>(Exception source) where T : Exception/*, IComparable, IConvertible, new()*/ {
            Exception tmpException = source;
            while (tmpException != null)
            {
                if (tmpException is T)
                    return (T)tmpException;

                tmpException = tmpException.InnerException;
            }
            //return new T();//if where contains new(), but "new()" should be the last one
            return default(T);
        }


        private void DivideByZeroExceptionHandler(DivideByZeroException foundDivideByZeroException) {
            Console.WriteLine("DivideByZeroExceptionHandler has been called");
        }

        private static void ExceptionHandler(Exception e) {
            Console.WriteLine("ExceptionHandler has been called");
        }

        private static void FormatExceptionHandler(FormatException foundFormatException) {
            Console.WriteLine("FormatExceptionHandler has been called");
        }

        private static Exception FindInnerException(Exception source, Type targetType) {
            Exception tmpException = source;
            while (tmpException != null)
            {
                if (tmpException.GetType().Equals(targetType))
                    return tmpException;

                tmpException = tmpException.InnerException;
            }
            return null;
        }

        public void DoWorkFirstPart(string v) {
            try
            {
                DoWorkSecondPart(int.Parse(v));
            }
            catch (ArgumentNullException e)
            {
                throw new InvalidOperationException("InvalidOperationException", e);
            }
            catch (ArgumentException e)
            {
                throw new FormatException("FormatException", e);
            }
        }

        public void DoWorkSecondPart(int v) {
            try
            {
                var tmp = 1 / v;
            }
            catch (DivideByZeroException e)
            {
                throw new ArgumentException("ArgumentException", e);
            }
        }
    }
}
