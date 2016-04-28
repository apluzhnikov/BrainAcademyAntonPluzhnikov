using BA.Lesson141.AP.GenericCollectionExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson141.AP.GenericCollectionExample
{
    class GenericCollection<T> : IGenericCollection<T>
    {
        int _index = -1;
        T[] arr = new T[4];

        public void Add(T element) {
            if (arr.Length - 1 < ++_index)
            {
                var newArr = new T[arr.Length * 2];
                arr.CopyTo(newArr, 0);
                arr = newArr;
            }
            arr[_index] = element;
        }

        public int Length { get { return _index + 1; } }

        public T this[int index] {
            get { return arr[index]; }
            set { arr[index] = value; }
        }

    }
}
