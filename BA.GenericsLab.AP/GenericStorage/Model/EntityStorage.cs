using BA.GenericsLab.AP.GenericStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.GenericsLab.AP.GenericStorage.Model
{
    class EntityStorage<T> : IEntityService<T> where T : BaseEntity
    {
        const int baseStorageSize = 10;
        T[] _storage = new T[baseStorageSize];
        int _index = -1;

        public void Add(T entity)
        {
            if (Find(entity.Id) == null)
            {
                if (_storage.Length - 1 < ++_index)
                {
                    var newStorage = new T[_storage.Length * 2];
                    _storage.CopyTo(newStorage, 0);
                }
                _storage[_index] = entity;
            }
        }

        public void Delete(T entity)
        {
            _storage = _storage.Where(arg => arg!= null && arg.Id != entity.Id).ToArray();
        }

        public T Find(int id)
        {
            return _storage.FirstOrDefault(arg => arg != null && arg.Id == id);
        }

        public T[] GetAll()
        {
            return _storage;
        }
    }
}
