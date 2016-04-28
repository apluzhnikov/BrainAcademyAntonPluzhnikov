using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson141.AP.GenericCollectionExample
{
    interface IGenericCollection<T>
    {
        T this[int index] { get; set; }

        void Add(T element);

        int Length { get; }
    }
}
