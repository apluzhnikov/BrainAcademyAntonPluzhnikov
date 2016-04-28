using Lab3.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.AbstractClasses
{
    public abstract class Computer
    {
        public short _cpu;
        public double _power;
        public short _memory;
        public int _hdd;
        public PCtype _pcType;

        public void Initialize(PCtype pcType)
        {
            Random rand = new Random();
            _cpu = (short)rand.Next(1, 8);
            _power = rand.Next(1, 2) + Math.Round(rand.NextDouble(), 2);
            _memory = (short)rand.Next(1, 16);
            _hdd = rand.Next(250, 2000);
            _pcType = pcType;
        }

        public override string ToString()
        {
            return string.Format("{0}: CPU - {1} cores, {2} HGz, memory - {3} GB, HDD - {4} GB", _pcType, _cpu, _power, _memory, _hdd);
        }

        //public abstract void testmetod();
    }
}
