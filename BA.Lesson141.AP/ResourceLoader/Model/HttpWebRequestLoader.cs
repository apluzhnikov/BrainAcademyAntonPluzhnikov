using BA.Lesson141.AP.ResourceLoader.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson141.AP.ResourceLoader.Model
{
    class HttpWebRequestLoader : ILoader
    {
        public string Load(Uri uri) {
            var httpWebRequest = HttpWebRequest.Create(uri);
            HttpWebResponse httpWeResponce = null;
            StreamReader streamReader = null;
            try
            {
                httpWeResponce = (HttpWebResponse)httpWebRequest.GetResponse();
                var stream = httpWeResponce.GetResponseStream();
                try
                {
                    streamReader = new StreamReader(stream);
                    return streamReader.ReadToEnd();
                }
                catch(IOException ex)
                {
                    throw new ResourseNotLoadedException("Could not load the resources", ex);
                }
                finally
                {
                    if (streamReader != null)
                        streamReader.Dispose();
                }
            }
            catch (WebException ex)
            {
                throw new ResourseNotLoadedException("Could not load the resources", ex);
            }
            finally
            {
                if (httpWeResponce != null)
                    httpWeResponce.Dispose();
            }

        }
    }
}
