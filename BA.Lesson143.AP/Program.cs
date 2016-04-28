using BA.Lesson143.AP.AnimalSortingLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson143.AP
{
    class Program
    {
        static void Main(string[] args) {


            DuplicationEntriesFinder duplicationEntriesFinder = new DuplicationEntriesFinder();

        }



        #region lesson
        static void Comparables() {
            List<Car> cars = new List<Car>();
            cars.Add(new Car { Power = 200, Title = "Audi" });
            cars.Add(new Car { Power = 60, Title = "Renault" });
            cars.Add(new Car { Power = 140, Title = "BMW" });
            cars.Add(new Car { Power = 140, Title = null });

            /*cars.Sort((car1, car2) => car1.Power > car2.Power ? 1 : 0);
            cars.Sort((car1, car2) => string.Compare(car1.Title, car2.Title) * -1);

            cars.Sort(new TitleCarComparerAsc());*/
            cars.Sort();

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }


            Console.ReadLine();
        }

        static void Collections() {
            int min = 1;
            int max = 10;
            List<int> numbers = new List<int>();

            for (int i = min; i <= max; i++)
            {
                numbers.Add(i);
            }

            numbers.RemoveAll(arg => arg % 2 == 0);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("Queue:");
            Queue<int> visitors = new Queue<int>();
            for (int i = min; i <= max; i++)
                visitors.Enqueue(i);


            while (visitors.Count > 0)
            {
                Console.WriteLine(visitors.Dequeue());
            }

            Console.WriteLine("Stack:");
            Stack<int> bullets = new Stack<int>();
            for (int i = min; i <= max; i++)
                bullets.Push(i);


            while (bullets.Count > 0)
            {
                Console.WriteLine(bullets.Pop());
            }


            Console.WriteLine("Dictionary:");
            Dictionary<string, string> vocabulary = new Dictionary<string, string>();
            for (int i = min; i <= max; i++)
                vocabulary.Add(i.ToString(), "edd" + i * 5 + "sass");


            if (vocabulary.ContainsKey("5"))
                Console.WriteLine(vocabulary["5"]);


            Console.WriteLine("Dictionary2:");
            Dictionary<MyKey, string> myobjects = new Dictionary<MyKey, string>();

            myobjects.Add(new MyKey { Id = 1, Id2 = 2 }, "Hello");
            myobjects.Add(new MyKey { Id = 11, Id2 = 21 }, "Good bye");

            var s = myobjects[new MyKey { Id = 1, Id2 = 2 }];

            if (vocabulary.ContainsKey("5"))
                Console.WriteLine(vocabulary["5"]);
        }
        #endregion
    }

    class MyKey
    {
        public int Id { get; set; }
        public int Id2 { get; set; }

        public string LevoePole { get; set; }

        public override int GetHashCode() {
            return Id.GetHashCode() ^ Id2.GetHashCode();
        }

        public override bool Equals(object obj) {
            MyKey other = obj as MyKey;
            if (other == null)
                return false;

            return this.Id == other.Id && this.Id2 == other.Id2;
        }
    }

    class Car : IComparable<Car>
    {
        public string Title { get; set; }
        public int Power { get; set; }

        public override string ToString() {
            return Title != null ? Title : "NoName";
        }

        public int CompareTo(Car other) {
            return string.Compare(this.Title, other.Title);
        }
    }

    class TitleCarComparerAsc : IComparer<Car>
    {
        public int Compare(Car car1, Car car2) {
            return string.Compare(car1.Title, car2.Title);
        }
    }
}
