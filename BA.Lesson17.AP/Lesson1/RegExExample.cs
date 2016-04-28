using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BA.Lesson17.AP.Lesson1
{
    static public class RegExExample
    {
        

        static public void FindStringInFile(string file, string regularExpression) {
            string line = string.Empty;
            using (var streamReader = new StreamReader(file))
            {
                line = streamReader.ReadToEnd();                
            }

            foreach(Match match in Regex.Matches(line, regularExpression)){
                Console.WriteLine(match.Value);
            }
            
        }
    }
}
