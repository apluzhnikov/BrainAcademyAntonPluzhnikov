using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson143.AP.AnimalSortingLab.Model
{
    class Animals : IEnumerable<Animal>
    {
        private Animal[] _animals;

        public Animals(int countOfAnimals) {
            _animals = new Animal[countOfAnimals];
        }

        public IEnumerator<Animal> GetEnumerator() {
            return GetEnumerator();
        }
        
        IEnumerator IEnumerable.GetEnumerator() {
            throw new NotImplementedException();
        }
    }
}
