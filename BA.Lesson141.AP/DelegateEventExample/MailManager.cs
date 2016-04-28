using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson141.AP.DelegateEventExample
{
    class MessageReseivedEventArgs : EventArgs
    {
        public string Message { get; set; }
    }

    class MailManager
    {
        /*public delegate void MessageReceivedHandler(object sender, string message);
        public event MessageReceivedHandler messageReceivedHandler;*/

        public event EventHandler<MessageReseivedEventArgs> messageReceived;

        internal void CheckNewMessage() {
            var message = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(message))
            {
                //OnMessageReceived(message);
                OnMessageReceived(new MessageReseivedEventArgs() { Message = message });
            }
        }

        /*protected virtual void OnMessageReceived(string message) {
            var handler = messageReceivedHandler;
            if (handler != null)
                handler(this, message);
        }*/

        protected virtual void OnMessageReceived(MessageReseivedEventArgs e) {
            var handler = messageReceived;
            if (handler != null)
                handler(this, e);
        }
    }
}
