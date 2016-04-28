using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson124.AP
{
    class Program
    {
        static void Main(string[] args) {

            object o = null; //"123";

            try
            {
                GetNameObj(o);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("NullReferenceException's Message: {0}", e.Message);
                Environment.FailFast(e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Base exception's Message: {0}", e.Message);
            }


            #region dynamic play and other
            /*dynamic dynamicVal = 123;
            //int dynamicVal = 123;
            Method(dynamicVal);
            Method(dynamicVal.ToString());

            int[] test = new[] { 3, 2, 5 };

            testMethod(ref test, 5, 1, 5, 1);
            */
            #endregion

            #region Box
            /*int valueTupe = 123;
            object o = valueTupe;

            //Console.WriteLine(o);
            int valueTypeCopy = (int)o;
            Console.WriteLine(valueTypeCopy);*/



            /*ArrayList arrayList = new ArrayList();
            arrayList.Add(valueTupe);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }*/
            #endregion



            Console.ReadLine();
        }


        static string GetNameObj(object obj) {
            Console.WriteLine(obj.ToString());
            return obj.ToString();
        }






        public static void Calculate(float amount) {
            object amountRef = amount;

            int balance = (int)(float)amountRef;

            //int balance = (int)(double)amountRef;

            Console.WriteLine(balance);
        }

        static void Method(int arg) {
            Console.WriteLine("int {0}", arg);
        }

        static void Method(string arg) {
            Console.WriteLine("string {0}", arg);
        }

        static void testMethod(ref int[] a, params int[] b) {

        }
    }
}
