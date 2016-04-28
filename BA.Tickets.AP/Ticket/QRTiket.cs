using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Tickets.AP.Ticket
{
    class QRTiket : Ticket
    {
        public override decimal Price {
            get {
                return 101.50m;
            }
        }

        public override string Title {
            get { return "QRTiket"; }
        }

        Random rand = new Random((int)DateTime.Now.Ticks);
        const int lineLength = 10;
        const char defBoardChar = '*';
        const char defLineChar = 'x';

        public string AdditionalInfo() {

            var qrtop = new string(defBoardChar, 5);
            var sb = new StringBuilder();

            sb.Append(qrtop);
            sb.Append(GetQRLine(lineLength));
            sb.AppendLine(qrtop);

            sb.Append(defBoardChar + "   " + defBoardChar);
            sb.Append(GetQRLine(lineLength));
            sb.AppendLine(defBoardChar + "   " + defBoardChar);

            sb.Append(defBoardChar + " " + defBoardChar + " " + defBoardChar);
            sb.Append(GetQRLine(lineLength));
            sb.AppendLine(defBoardChar + " " + defBoardChar + " " + defBoardChar);

            sb.Append(defBoardChar + "   " + defBoardChar);
            sb.Append(GetQRLine(lineLength));
            sb.AppendLine(defBoardChar + "   " + defBoardChar);

            sb.Append(qrtop);
            sb.Append(GetQRLine(lineLength));
            sb.AppendLine(qrtop);

            for (int i = 0; i < lineLength/2; i++)
            {
                sb.AppendLine(GetQRLine(lineLength + (qrtop.Length * 2)));
            }

            sb.Append(qrtop);
            sb.AppendLine(GetQRLine(lineLength + qrtop.Length));

            sb.Append(defBoardChar + "   " + defBoardChar);
            sb.AppendLine(GetQRLine(lineLength + qrtop.Length));


            sb.Append(defBoardChar + " " + defBoardChar + " " + defBoardChar);
            sb.AppendLine(GetQRLine(lineLength + qrtop.Length));

            sb.Append(defBoardChar + "   " + defBoardChar);
            sb.AppendLine(GetQRLine(lineLength + qrtop.Length));

            sb.Append(qrtop);
            sb.AppendLine(GetQRLine(lineLength + qrtop.Length));

            return sb.ToString();
        }

        private string GetQRLine(int length) {
            var sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                if (rand.Next(0, 10) > 4)
                    sb.Append(defLineChar);
                else
                    sb.Append(" ");
            }
            return sb.ToString();
        }
    }
}
