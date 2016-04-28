using BA.Tickets.AP.Ticket;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Tickets.AP
{
    class Program
    {
        static void Main(string[] args) {

            TicketPrinter ticketPrinter = new TicketPrinter();

            /*args = new string[]
                {
                    "UKR"
                };
            */

            
            //var date = DateTime.Parse(DateTime.UtcNow.ToString(), new CultureInfo("en-US"));
            //var date = DateTime.Now.ToString("D", CultureInfo.CreateSpecificCulture("en"));

            if (args.Length == 0)
            {
                args = new string[]
                {
                    "en"
                };
            }

            ITicket[] tickets = new ITicket[]
            {
                new QRTiket() { Lang = args[0], Date = DateTime.Now},
                new SimpleTicket() {Lang = args[0], Date = (DateTime.Now).AddHours(-5).AddDays(-2)  }
            };

            Console.WriteLine("Please select Priting device:");
            Console.WriteLine("1: {0}", PrintType.Console);
            Console.WriteLine("2: {0}", PrintType.File);
            Console.WriteLine("3: {0}", PrintType.Output);

            int printType = -1;
            if ((int.TryParse(Console.ReadLine(), out printType)) && (printType > -1) && (printType < 4))
            {
                for (int i = 0; i < tickets.Length; i++)
                {
                    ticketPrinter.Print(tickets[i], (PrintType)printType - 1, i);
                }
                Console.WriteLine("Process is finished");
            }
            Console.ReadLine();
        }
    }
}
