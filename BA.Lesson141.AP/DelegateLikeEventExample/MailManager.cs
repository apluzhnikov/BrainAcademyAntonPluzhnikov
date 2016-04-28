using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson141.AP.DelegateLikeEventExample
{
    class MailManager
    {
        public delegate void MessageReceivedHandler(object sender, string message);

        MessageReceivedHandler _messageReceivedHandler;

        public MessageReceivedHandler DelegateMessageReceivedHandler {
            get {
                return _messageReceivedHandler;
            }

            set {
                if (value != null)
                    _messageReceivedHandler = value;
            }
        }

        internal void CheckNewMessage() {
            var message = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(message))
            {
                OnMessageReceived(message);
            }
        }

        protected virtual void OnMessageReceived(string message) {
            var handler = _messageReceivedHandler;
            if (handler != null)
                handler(this, message);
        }
    }
}
