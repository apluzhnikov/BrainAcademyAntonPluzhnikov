using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.GenericsLab.AP.GenericStorage.Model
{
    abstract class BaseEntity
    {
        internal int Id { get; set; }
        internal string Name { get; set; }
        internal int Price { get; set; }

        public override string ToString() {
            return "Please override this Entity's ToString() to see the description of this object";
        }
    }
}
