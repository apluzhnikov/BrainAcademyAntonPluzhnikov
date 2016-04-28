using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BA.Lesson141.AP.MyEventExample
{
    class MyEventArgs : EventArgs
    {
        public string Message { get; set; }
        public string Error { get; set; }

        
    }

    class MyClassWithEvent
    {
        string _message;
        public string Message {
            get { return _message; }
            set {
                _message = value;
                OnMessageReceived(this, new MyEventArgs { Message = _message });
            }
        }        

        public event EventHandler<MyEventArgs> MessageReceivedRaised;
        public event EventHandler<MyEventArgs> MessageReceivingRaised;
        private readonly object eventLock = new object();


        protected virtual void OnMessageReceived(object sender, MyEventArgs arg) {
            EventHandler<MyEventArgs> handler;
            lock (eventLock)
            {
                handler = MessageReceivedRaised;
            }

            if (handler != null)
            {
                if (!string.IsNullOrWhiteSpace(arg.Message))
                    handler(this, new MyEventArgs() { Message = arg.Message });
                else
                    handler(this, new MyEventArgs() { Error = "Message is empty" });
            }
        }
        
        protected virtual void OnMessageReceiving(object sender, MyEventArgs arg) {

            EventHandler<MyEventArgs> handler;
            lock(eventLock)
            {
                handler = MessageReceivedRaised;
            }

            if (handler != null)
            {
                handler(this, arg);
            }
        }

        public void StartTyping() {
            OnMessageReceiving(this, new MyEventArgs() { Message = "Someone started to type" });
        }

    }
}
