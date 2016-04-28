using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BA.Lesson141.AP.ResourceLoader.Exceptions;

namespace BA.Lesson141.AP.ResourceLoader
{
    interface ILoader
    {
        /// <summary>
        /// Loads web resource
        /// </summary>
        /// <exception cref="ResourseNotLoadedException"/>
        /// <param name="uri">Uri of web resource</param>
        /// <returns>Web resource like string</returns>
        string Load(Uri uri);
    }
}
