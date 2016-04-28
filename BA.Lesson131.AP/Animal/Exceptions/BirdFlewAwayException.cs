using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson131.AP.Animal.Exceptions
{
    class BirdFlewAwayException : Exception
    {
        public BirdState BirdStatus { get; private set; }

        public BirdFlewAwayException(string message, BirdState birdState) : base(message) {
            BirdStatus = birdState;
        }

        public override string Message {
            get {
                return string.Format("{0}, current bird status: {1} ",base.Message, BirdStatus);
            }
        }
    }
}
