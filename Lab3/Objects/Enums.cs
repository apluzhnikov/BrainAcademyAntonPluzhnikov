using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Objects
{
    public enum PCtype
    {
        Desctop,
        Laptop,
        Server
    }

    public struct Position
    {
        public int xpos;
        public int ypos;
    }

    public struct Statistic
    {
        public int Count;
        public Position LargestHDD;
        public Position LowestProductivity;
    }
}
