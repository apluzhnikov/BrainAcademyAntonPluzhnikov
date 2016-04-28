using BA.Lesson141.AP.ResourceLoader.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson141.AP.ResourceLoader.Model
{
    class WebClientLoader : ILoader
    {
        public string Load(Uri uri) {
            WebClient webClient = new WebClient();
            try {
                return webClient.DownloadString(uri);
            }
            catch (WebException ex)
            {
                throw new ResourseNotLoadedException("Could not load the resources", ex);
            }
        }
    }
}
