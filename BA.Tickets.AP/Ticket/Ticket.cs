using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Tickets.AP.Ticket
{
    abstract class Ticket : ITicket
    {
        public DateTime Date { get; set; }

        public string Lang { get; set; }

        public abstract decimal Price { get; }

        public abstract string Title { get; }

        public override string ToString() {
            //var date = Date.ToString();
            /*if (string.Equals(Lang, "ukr", StringComparison.InvariantCultureIgnoreCase))
                date = Date.ToString("yyyy-dd-mm");*/

            /*CultureInfo culture = new CultureInfo(Lang);
            var date = Date.ToString("O", culture);*/
            //Lang
            var date = Date.ToString("D", CultureInfo.CreateSpecificCulture(Lang));
            var price = Price.ToString("C", CultureInfo.CreateSpecificCulture(Lang));

            return string.Format("Title {0}\r\nDate {1}\r\nPrice{2}", Title, date, price);
        }
    }
}
