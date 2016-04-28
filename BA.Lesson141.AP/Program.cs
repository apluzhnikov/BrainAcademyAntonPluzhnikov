using BA.Lesson141.AP.DelegateEventExample;
using BA.Lesson141.AP.DelegateExample;
using BA.Lesson141.AP.GenericCollectionExample;
using BA.Lesson141.AP.GenericDelegatesExample;
using BA.Lesson141.AP.GenericsAndExceptions;
using BA.Lesson141.AP.MyEventExample;
using BA.Lesson141.AP.ResourceLoader;
using BA.Lesson141.AP.ResourceLoader.Exceptions;
using BA.Lesson141.AP.ResourceLoader.Model;
using BA.Lesson141.AP.SpamEvents;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson141.AP
{
    class Program
    {



        static void Main(string[] args) {

            start:

            GenericDelegates();

            //GenericCollectionExample();
            //GenericsAndExceptionsFunc();

            //MyEvent();
            //Event();
            //SortArrayWithDelegate();
            //DelegatExample();



            Console.ReadLine();
            goto start;
        }



        #region lesson 1.4.2


        #region GenericDelegates
        static void GenericDelegates() {
            GenericCovariacity genericCovariacity = new GenericCovariacity();
        }
        #endregion

        #region GenericCollection

        static void GenericCollectionExample() {
            GenericCollection<int> genericCollectionInts = new GenericCollection<int>();
            genericCollectionInts.Add(4);
            genericCollectionInts.Add(24);
            genericCollectionInts.Add(45);
            genericCollectionInts.Add(422);
            genericCollectionInts.Add(44);
            genericCollectionInts.Add(41);
            genericCollectionInts.Add(41);

            for(int i = 0; i < genericCollectionInts.Length; i++)
            {
                Console.WriteLine(genericCollectionInts[i]);
            }

            GenericCollection<int> genericCollectionInts2 = new GenericCollection<int>();
            genericCollectionInts2.Add(4);
            genericCollectionInts2.Add(24);
            genericCollectionInts2.Add(45);

            GenericCollection<string> genericCollectionString = new GenericCollection<string>();
            genericCollectionString.Add("a");
            genericCollectionString.Add("b");
            genericCollectionString.Add("c");
            genericCollectionString.Add("d");
            genericCollectionString.Add("e");
            genericCollectionString.Add("f");
            genericCollectionString.Add("g");
            genericCollectionString.Add("k");
            genericCollectionString.Add("j");

            for (int i = 0; i < genericCollectionString.Length; i++)
            {
                Console.WriteLine(genericCollectionString[i]);
            }

            Console.ReadLine();
        }

        #endregion

        #region GenericsAndExceptions

        static void GenericsAndExceptionsFunc() {
            GenericsAndExceptionsExample genericsAndExceptionsExample = new GenericsAndExceptionsExample();
        }
        #endregion

        #endregion

        #region SpamEvents
        static void SpamEvents() {
            MailRu mailRu = new MailRu();
            mailRu.SendFailed += LogToConsole;
            mailRu.SendFailed += LogToDebug;
            mailRu.SendFailed += delegate (object sender, SmsEventArgs e)
            {
                Console.WriteLine(string.Format("ANONYMUS!! failed to send sms for {0}", e.Name));
            };
            mailRu.SendFailed += (sender, e) =>
            {
                Console.WriteLine(string.Format("LAMBDA!! failed to send sms for {0}", e.Name));
            };
            mailRu.SendNotification();
        }


        private static void LogToDebug(object sender, SmsEventArgs e) {
            Debug.Print(string.Format("General!! failed to send sms for {0}", e.Name));
        }

        private static void LogToConsole(object sender, SmsEventArgs e) {
            Console.WriteLine(string.Format("General!! failed to send sms for {0}", e.Name));
        }

        #endregion

        #region myClassWithEvent
        static void MyEvent() {
            MyClassWithEvent myClassWithEvent = new MyClassWithEvent();
            Console.WriteLine("Please enter a message:");


            myClassWithEvent.MessageReceivingRaised += MessageCatcher.MessageReceivingEventHandler;
            myClassWithEvent.StartTyping();


            myClassWithEvent.MessageReceivedRaised += ErrorCatcher.ErrorReceivedEventHandler;
            myClassWithEvent.MessageReceivedRaised += MessageCatcher.MessageReceivedEventHandler;
            myClassWithEvent.Message = Console.ReadLine();
        }
        #endregion


        #region Comparing
        delegate int CompareInts(int first, int second);

        static void SortArrayWithDelegate() {
            CompareInts compareInts = null;
            compareInts += ComparingInts;

            //IComparable<int> comparable = compareInts;

            int[] sortArray = new int[10];
            Random rand = new Random();
            for (int i = 0; i < sortArray.Length; i++)
            {
                sortArray[i] = rand.Next(0, 100);
                Console.Write(sortArray[i] + ", ");
            }

            Console.WriteLine();
            //Array.Sort(sortArray, delegate (int i, int y) { return y.CompareTo(i); });//descending
            Array.Sort(sortArray, delegate (int i, int y) { return i.CompareTo(y); });//ascending

            //Array.Sort(sortArray, 

            foreach (int i in sortArray)
            {
                Console.Write(i + ", ");
            }
            Console.ReadLine();
        }

        static int ComparingInts(int first, int second) {
            return (first > second) ? first : second;
        }
        #endregion



        #region Events

        static void Event() {
            MailManager mailManager = new MailManager();

            /*mailManager.messageReceivedHandler += Printer.MessageEventHandler;
            mailManager.messageReceivedHandler += ConsolePrinter.MessageEventHandler;            */

            mailManager.messageReceived += Printer.MessageEventHandler;
            mailManager.messageReceived += ConsolePrinter.MessageEventHandler;

            mailManager.CheckNewMessage();

            /*mailManager.messageReceivedHandler -= ConsolePrinter.MessageEventHandler;*/
            mailManager.messageReceived -= ConsolePrinter.MessageEventHandler;


            mailManager.CheckNewMessage();
        }

        static void LikeEvent() {
            /*MailManager mailManager = new MailManager();

            DelegateLikeEventExample.mailManager.DelegateMessageReceivedHandler += Printer.MessageEventHandler;
            DelegateLikeEventExample.mailManager.DelegateMessageReceivedHandler += ConsolePrinter.MessageEventHandler;
            mailManager.DelegateMessageReceivedHandler = null;

            mailManager.CheckNewMessage();*/
        }
        #endregion


        #region DelegatExample
        delegate int MathOperation(int first, int second);

        static void DelegatExample() {


            CalculateChaining();

            //Calculate();
        }

        private static void CalculateChaining() {
            Console.WriteLine("Please enter first arg");
            var firstArg = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second arg");
            var secondArg = int.Parse(Console.ReadLine());

            Calculator calc = new Calculator();
            MathOperation mathOperation = null;

            //combaining delegates 1 option
            /*mathOperation = (MathOperation)Delegate.Combine(mathOperation, 
                new MathOperation(calc.Sum));
            mathOperation = (MathOperation)Delegate.Combine(mathOperation,
                new MathOperation(calc.Sub));
            mathOperation = (MathOperation)Delegate.Combine(mathOperation,
                new MathOperation(Calculator.Mul));
            mathOperation = (MathOperation)Delegate.Combine(mathOperation,
                new MathOperation(Calculator.Div));*/
            //combaining delegates 2 option
            /*mathOperation += new MathOperation(calc.Sum);*/

            //combaining delegates 3 option
            mathOperation += calc.Sum;
            mathOperation += calc.Sub;
            mathOperation += Calculator.Mul;
            mathOperation += Calculator.Div;

            CalcDurationTime(mathOperation, firstArg, secondArg);

            /*mathOperation -= Calculator.Mul;

            CalcDurationTime(mathOperation, firstArg, secondArg);*/
        }

        static void Calculate() {
            Console.WriteLine("Please enter first arg");
            var firstArg = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second arg");
            var secondArg = int.Parse(Console.ReadLine());

            Calculator calc = new Calculator();
            MathOperation mathOperation = null;

            Console.WriteLine("Please enter operation (Sum, Sub, Mul, Div)");
            var operationName = Console.ReadLine();
            Console.WriteLine("Operation will be with numbers: {0} and {1}", firstArg, secondArg);

            switch (operationName)
            {
                case "Sum":
                    mathOperation = new MathOperation(calc.Sum);
                    break;
                case "Sub":
                    mathOperation = calc.Sub;
                    break;
                case "Mul":
                    mathOperation = new MathOperation(Calculator.Mul);
                    break;
                case "Div":
                    mathOperation = Calculator.Div;
                    break;
            }
            if (mathOperation != null)
            {
                CalcDurationTime(mathOperation, firstArg, secondArg);
                //Console.WriteLine($"Operation result: {  }");
            }
        }
        static void CalcDurationTime(MathOperation mathOperation, int first, int second) {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine(mathOperation(first, second));
            //Console.WriteLine($"Operation result: { mathOperation(first, second) }"); 

            stopwatch.Stop();
            Console.WriteLine($"Duration: {stopwatch.ElapsedTicks}");
        }

        #endregion

        #region other ResourceLoader
        static void RunResourceLoader() {
            Console.WriteLine("Please enter url");
            var urlString = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(urlString))
            {

                Console.WriteLine("Please select type of loader:\nA - WebClientLoader\nB - HttpWebRequestLoader");


                //pattern Fabric
                ILoader loader = LoaderFactory.Create(Console.ReadKey().Key);

                Console.WriteLine(" - will be used -> {0} ", loader.GetType().Name);
                string resultOfLoad = string.Empty;
                try
                {
                    resultOfLoad = loader.Load(new Uri(urlString));
                }
                catch (ResourseNotLoadedException ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                if (!string.IsNullOrWhiteSpace(resultOfLoad))
                {
                    Console.WriteLine("Website as string:\n{0}", resultOfLoad);
                } else
                {
                    Console.WriteLine("The webClientLoader returned an empty string");
                }
            } else
            {
                Console.WriteLine("Url is not valid");
                Console.ReadLine();
                return;
            }
        }

        #endregion
    }
}
