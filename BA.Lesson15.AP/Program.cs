using BA.AP.Examples;
using BA.AP.Examples.MyCollection;
using NLog;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace BA.Lesson15.AP
{
    public enum Status
    {
        Arrived,
        Canceled,
        Delayed,
        Unknown
    }
        

    [Serializable]
    public class Flight
    {
        [XmlText]
        [CsvAttribute("CsvCity")]
        public string City { get; set; }

        [XmlAttribute("FlightNumber")]
        [CsvAttribute("CsvNumber")]
        [CustomAttribute]
        public int Number { get; set; }

        [XmlAttribute]
        [CsvAttribute("CsvStatus")]
        public Status Status { get; set; }
    }

    static class BASerrializor
    {
        public static XElement SerrializeToXml<T>(T obj) {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (MemoryStream memoryStream = new MemoryStream())
            {
                xmlSerializer.Serialize(memoryStream, obj);
                memoryStream.Position = 0;
                return XElement.Load(memoryStream);
            }
        }

        public static string SerrializeToCsv<T>(IEnumerable<T> obj, string columnseparator) {
            CsvSerrializer csvSerrializer = new CsvSerrializer(typeof(T), columnseparator);
            return csvSerrializer.Serrialize(obj);
        }

    }

    //attribute
    [Serializable]

    
    class Program
    {

        
        [Obsolete("sddshthryk")]
        static void Main(string[] args) {
            

            //Mycollection();
            //ReflectionMethod();
            //TracingExample();

            Console.ReadLine();
        }



        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void TracingExample() {
            //logger = LogManager.GetCurrentClassLogger();
            TraceSource ts = new TraceSource("MyTraceSource");
            /*var tr = new TextWriterTraceListener("LogAndTrace.txt");
            var xt = new XmlWriterTraceListener("LogAndTrace.xml");
            var dt = new DelimitedListTraceListener("LogAndTrace.csv");
            var et = new EventLogTraceListener("LogAndTrace");
            
            
            ts.Switch = new SourceSwitch("mySwitch", "my switch");
            ts.Switch.Level = SourceLevels.Warning;
            

            dt.Delimiter = ",";
            dt.TraceOutputOptions = TraceOptions.DateTime ;
            xt.TraceOutputOptions = TraceOptions.DateTime | TraceOptions.Timestamp  ;
            tr.TraceOutputOptions = TraceOptions.DateTime | TraceOptions.Timestamp | TraceOptions.Callstack;

            ts.Listeners.Clear();

            ts.Listeners.Add(dt);
            ts.Listeners.Add(xt);
            ts.Listeners.Add(tr);


            Trace.AutoFlush = true;*/


            logger.Debug("Myfirst NLog message");

            /*ts.TraceEvent(TraceEventType.Warning, 0, "Warning message1");
            ts.TraceEvent(TraceEventType.Information, 0, "Warning message2");
            ts.TraceEvent(TraceEventType.Error, 0, "Warning message3");*/
        }


        static void ReflectionMethod() {
            Flight[] flights = new Flight[]
            {
                new Flight {Number = 1,City="London", Status = Status.Unknown },
                new Flight {Number = 2,City="Berlin", Status = Status.Delayed },
                new Flight {Number = 3,City="Dublin", Status = Status.Canceled },
                new Flight {Number = 4,City="Kharkiv", Status = Status.Arrived }
            };

            foreach (var flight in flights)
            {
                var xelment = BASerrializor.SerrializeToXml(flight);
                xelment.Save($"D:\\{flight.City}.xml");
            }
            BASerrializor.SerrializeToXml(flights).Save($"D:\\Flights.xml");

            var csvdata = BASerrializor.SerrializeToCsv(flights, ";");
            string csvFilePath = @"D:\\Flights.csv";
            if (File.Exists(csvFilePath))
                File.Delete(csvFilePath);
            File.AppendAllText(csvFilePath, csvdata);
        }



        static void Mycollection() {
            Console.WriteLine("Please enter the DIVIDER 3 or 2");
            int divider = 0;
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out divider); Console.WriteLine();

            Console.WriteLine("Please type the top limit of digits");
            int topLimit = 0;
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out topLimit); Console.WriteLine();

            MyCollectionSettings myCollectionSettings = new MyCollectionSettings { DividerReceived = divider, OurTopLimit = topLimit };

            Validator validator = new Validator();
            validator.ErrorDividerReceived += OnIncorrectDividerReceived;
            validator.Validate(myCollectionSettings);
            MyCollection myCollection = new MyCollection(myCollectionSettings);

            foreach (var myCollectionItem in myCollection)
            {
                Console.WriteLine(myCollectionItem);
            }
            Console.ReadLine();
        }


        private static void OnIncorrectDividerReceived(object sender, ErrorDividerEventArgs e) {
            Console.WriteLine("Error occured: {0}", e.Message);
        }

        [Conditional("DEBUG")]
        static void Method() {

        }
    }
}

