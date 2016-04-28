using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson141.AP.GenericDelegatesExample
{
    class GenericCovariacity
    {
        delegate TResult MyDelegate<in T, out TResult>(T arg);

        public GenericCovariacity() {

            MyDelegate<string, object> myDelegate = new MyDelegate<string, object>(Handler03);
            //myDelegate += Handler02;

            var result = myDelegate("Hello");

            Console.WriteLine(result);
        }

        object Handler01(string arg) {
            return $"Handler01 method returns an OBJECT type. Arg value: {arg}";
        }

        string Handler02(string arg) {
            return $"Handler02 method returns an STRING type. Arg value: {arg}";//covariant
        }

        object Handler03(object arg) {
            return $"Handler03 method returns an OBJECT type. Arg value is an OBJECT type: {arg}";//contrvariant
        }
    }
}
