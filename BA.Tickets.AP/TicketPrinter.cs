using BA.Tickets.AP.Ticket;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Tickets.AP
{
    class TicketPrinter
    {
        public void Print(ITicket ticket, PrintType printType, int ticketIndex) {
            switch (printType)
            {
                case PrintType.Console:
                    ToConsole(ticket, ticketIndex);
                    break;
                case PrintType.File:
                    ToFile(ticket, ticketIndex);
                    break;
                case PrintType.Output:
                    ToOutput(ticket, ticketIndex);
                    break;
            }
        }

        private void ToOutput(ITicket ticket, int ticketIndex) {
            Debug.WriteLine("Ticket #{0}", ticketIndex + 1);
            Debug.WriteLine(ticket);
            QRTiket qrTicket = ticket as QRTiket;
            if (qrTicket != null)
            {
                Debug.WriteLine(qrTicket.AdditionalInfo());
            }
        }

        private void ToConsole(ITicket ticket, int ticketIndex) {
            Console.WriteLine("Ticket #{0}", ticketIndex + 1);
            Console.WriteLine(ticket);
            QRTiket qrTicket = ticket as QRTiket;
            if (qrTicket != null)
            {
                Console.WriteLine(qrTicket.AdditionalInfo());
            }
        }

        private void ToFile(ITicket ticket, int ticketIndex) {

            using (StreamWriter file = new StreamWriter(string.Format(@"D:\ticket{0}.txt", ticketIndex + 1)))
            {
                file.WriteLine(ticket);
                QRTiket qrTicket = ticket as QRTiket;
                if (qrTicket != null)
                {
                    file.WriteLine(qrTicket.AdditionalInfo());
                }

            }
        }
    }

    enum PrintType
    {
        Console,
        File,
        Output
    }
}
