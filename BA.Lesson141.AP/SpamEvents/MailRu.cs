using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson141.AP.SpamEvents
{
    class MailRu
    {
        private Random _random = new Random();

        private string[] _recepients =
        {
            "Dima", "Kirill", "Karina", "Denis", "Nastja","Oleg", "Alexander"
        };

        /*public delegate void MailRuHandler(object sender, SmsEventArgs args);
        public event MailRuHandler SendFailed;*/

        public event EventHandler<SmsEventArgs> SendFailed;
        protected virtual void OnSendFailed(object sender, SmsEventArgs args) {
            var handler = SendFailed;
            if (handler != null)
                handler(this, args);
        }


        public void SendNotification() {
            foreach (string recepient in _recepients)
            {
                int result = _random.Next(1, 3);
                if (result == 1)
                {
                    OnSendFailed(this, new SmsEventArgs { Name = recepient });
                }
            }
        }
    }

    class SmsEventArgs : EventArgs
    {
        public string Name { get; set; }
    }
}
