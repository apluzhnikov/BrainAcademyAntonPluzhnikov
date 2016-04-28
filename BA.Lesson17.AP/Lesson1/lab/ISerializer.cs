using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson17.AP.Lesson1.lab
{
    interface ISerializer
    {
        void Deserialize(string file);
        void Deserialize(FileStream stream);
        void Serialize(string file);
    }
}
