using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson143.AP.AnimalSortingLab.Model
{
    class Animal : IComparable<Animal>
    {
        public string Genus { get; }
        public int Weight { get; }

        public Animal(string genus, int weight) {
            Genus = genus;
            Weight = weight;
        }

        public int CompareTo(Animal other) {
            return string.Compare(Genus, other.Genus);
        }

        public static IComparer<Animal> SortWeightAsc(Animal animal1, Animal animal2) {
            return new SortWeightAscendingHelper();
        }

        public static IComparer<Animal> SortGenusDesc(Animal animal1, Animal animal2) {
            return new SortGenusDescendingHelper();
        }
    }
}
