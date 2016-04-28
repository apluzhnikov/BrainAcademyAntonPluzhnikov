using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson143.AP.AnimalSortingLab.Model
{
    class SortGenusDescendingHelper : IComparer<Animal>
    {
        public int Compare(Animal animal1, Animal animal2) {
            return string.Compare(animal2.Genus, animal1.Genus);
        }
    }
}
