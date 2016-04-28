using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Tickets.AP.Ticket
{
    class SimpleTicket : Ticket
    {
        public override string Title {
            get { return "Simple tiket"; }
        }

        public override decimal Price {
            get {
                return 30.50m;
            }
        }
    }
}
