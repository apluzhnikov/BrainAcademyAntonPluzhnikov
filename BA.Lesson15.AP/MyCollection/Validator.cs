using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.AP.Examples.MyCollection
{
    internal class ErrorDividerEventArgs : EventArgs
    {
        public string Message { get; set; }
    }
    internal class Validator
    {

        public event EventHandler<ErrorDividerEventArgs> ErrorDividerReceived;
        private readonly object locker = new object();
        protected virtual void OnIncorrectDividerReceived(ErrorDividerEventArgs args) {
            EventHandler<ErrorDividerEventArgs> handler;
            lock (locker)
            {
                handler = ErrorDividerReceived;
            }
            if (handler != null)
                handler(this, args);
        }

        public void Validate(MyCollectionSettings myCollectionSettings) {
            if (myCollectionSettings.DividerReceived != 2 && myCollectionSettings.DividerReceived != 3)
            {
                myCollectionSettings.Divider = 2;
                OnIncorrectDividerReceived(new ErrorDividerEventArgs { Message = $"Incorrect divider provided: {myCollectionSettings.DividerReceived} , will be used default {myCollectionSettings.Divider}" });
            } else
                myCollectionSettings.Divider = myCollectionSettings.DividerReceived;

            if (myCollectionSettings.OurTopLimit == 0)
            {
                myCollectionSettings.Divider = 2;
                OnIncorrectDividerReceived(new ErrorDividerEventArgs { Message = $"Incorrect divider provided: {myCollectionSettings.DividerReceived} , will be used default {myCollectionSettings.Divider}" });
            } else
                myCollectionSettings.Divider = myCollectionSettings.DividerReceived;

        }
    }
}
