using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson141.AP.ResourceLoader.Exceptions
{
    class ResourseNotLoadedException : Exception
    {
        public ResourseNotLoadedException() : base() { }
        public ResourseNotLoadedException(string message) : base(message) { }
        public ResourseNotLoadedException(string message, Exception innerException) : base(message, innerException) { }
    }
}
