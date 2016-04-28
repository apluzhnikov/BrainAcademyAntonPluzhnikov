using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.GenericsLab.AP.GenericStorage
{
    interface IEntityService<T>
    {
        T Find(int id);
        void Add(T entity);
        void Delete(T entity);
        T[] GetAll();
    }
}
