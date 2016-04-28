using BA.Lesson141.AP.ResourceLoader.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson141.AP.ResourceLoader
{
    static class LoaderFactory
    {
        public static ILoader Create(ConsoleKey type) {
            switch (type)
            {
                case ConsoleKey.A:
                    return new WebClientLoader();
                case ConsoleKey.B:
                    return new HttpWebRequestLoader();
                default:
                    throw new NotImplementedException("This loader doesn't exist");
            }
        }
    }
}
