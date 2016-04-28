using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson143.AP.AnimalSortingLab.Model
{
    class Car
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }

    class DuplicationEntriesFinder
    {

        int[] _intsArray = { 1, 4, 6, 2, 8, 1, 6 };
        string[] _stringArray = { "string1", "string4", "string1", "string2", "string18" };
        Car[] _cars =
        {
            new Car {Name = "BMW", Price = 200 },
            new Car {Name = "BM2W", Price = 20 },
            new Car {Name = "BM\a", Price = 240 },
            new Car {Name = "BMsdgfW", Price = 210 },
            new Car {Name = "BMW", Price = 200 }
        };

        public DuplicationEntriesFinder()
        {
            bool duplicated = false;
            /*duplicated = FindDuplicationEntries(_intsArray);
            Console.WriteLine($"Ints duplicated: {duplicated}");
            duplicated = FindDuplicationEntries(_stringArray);
            Console.WriteLine($"Strings duplicated: {duplicated}");*/
            duplicated = FindDuplicationEntries(_cars);
            Console.WriteLine($"Cars duplicated: {duplicated}");
            Console.WriteLine();
            Console.ReadLine();
        }

        public bool FindDuplicationEntries<T>(IEnumerable<T> list) 
        {

            //duplication = list.Where((arg1, arg2) => arg1.Equals(arg2)).Count();

            //duplication = list.GroupBy<T, T>((arg1,arg2) =>EqualityComparer<T>.Default.Equals(arg1,arg2)).Count();
            //var test = from arg in list where EqualityComparer<T>.Default.Equals(arg) select arg;
            //var test = list.GroupBy(arg => arg, (arg1, arg2) => Equals(arg1, arg2));
            //var countGroupped = list.GroupBy((arg1, arg2) => arg1 arg2)


            /*//works well
            var distinct = list.Distinct().Count();
            var allcount = list.Count();
            return distinct != allcount;*/


            var result = list.Union(

            return list.Union(list).Count() != list.Count();
        }

        public static bool Equals<T>(T a, T b)
        {
            return EqualityComparer<T>.Default.Equals(a, b);
        }
    }
}
