using Lab3.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Objects
{
    class ServerPC : Computer
    {
        public ServerPC()
        {
            Initialize(PCtype.Server);
        }
    }
}
