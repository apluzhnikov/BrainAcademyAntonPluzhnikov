using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.GenericsLab.AP.GenericStorage.Model
{
    internal class BookEntity : BaseEntity
    {
        internal string Description { get; set; }

        public override string ToString() {
            return string.Format("ID: {0}, Name: {1}, Description: {2}, Price {3}", Id, Name, Description, Price);
        }
    }
}
