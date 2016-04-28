using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_Morze
{
    class Program
    {
        //Abrams / Zvalina / Jon Skit -> book

        int m_counter = 0;
        int _counter = 0;
        static int s_counter = 0;



        //USE ONLY STRING BUILDER!!!!!!!!!!!!!! it's much faster then just adding string, 14 times faster
        /*
        in release speed is faster then in debug
        */

        static void Main(string[] args)
        {

            string teststring = string.Empty;
            //teststring

            /*StreamWriter streamWriter = new StreamWriter(@"d:\lab4file.txt");
            Console.SetOut(streamWriter);*/
            Console.WriteLine("Please enter two values separeate by '#':");
            string gotString = Console.ReadLine();
            string unaryString = GetDiff(gotString);
            Console.WriteLine("Unary difference between {0} is {1}", gotString, unaryString);
            Console.ReadLine();

            string binaryVal = GetBinaryVal(unaryString);

            //Console.Out.Flush();
        }

        private static string GetBinaryVal(string unaryString)
        {
            int unaryVal = unaryString.Length;
            string binaryVal = string.Empty;
            while (unaryVal > 0) {
                var rest = unaryVal % 2;
                binaryVal += rest > 0 ? 1 : 0;
                unaryVal = unaryVal / 2;
            }

            binaryVal = binaryVal.ToCharArray().Reverse().ToString();
            return binaryVal;
        }

        static public string GetDiff(string gotString)
        {
            const char separator = '#';
            string[] values = gotString.Split(separator);
            string unaryString = string.Empty;
            const int unaryVal = 1;
            if (values.Length == 2) {
                int absVal = Math.Abs(int.Parse(values[0]) - int.Parse(values[1]));

                for (int i = 0; i < int.Parse(values[0]); i++) {
                    unaryString += unaryVal;
                }
                unaryString += "#";
                for (int i = 0; i < int.Parse(values[1]); i++) {
                    unaryString += unaryVal;
                }

            }

            const string forReplace = "1#1";
            while (unaryString.IndexOf("1#1") > -1) {
                unaryString = unaryString.Replace(forReplace, separator.ToString());
            }
            unaryString = unaryString.Replace(separator.ToString(), "");
            return unaryString;
            
        }
    }
}
