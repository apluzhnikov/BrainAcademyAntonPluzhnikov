using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Tickets.AP.Ticket
{
    interface ITicket
    {
        string Lang { get; set; }
        string Title { get; }
        DateTime Date { get; set; }
        decimal Price { get; }
        

    }
}
