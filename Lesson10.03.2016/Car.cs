using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10._03._2016
{
    class Car
    {
        public int Year { get; set; }
        public string Name { get; set; }
        public int HoursePower { get; set; }

        public override string ToString() {
            return Name;
        }

        public static bool operator ==(Car car1, Car car2) {
            //return (car1.Name == car2.Name) && (car1.Year == car2.Year);
            return string.Equals(car1.Name,car2.Name, StringComparison.InvariantCultureIgnoreCase)
                && (car1.Year == car2.Year);
        }

        public static bool operator !=(Car car1, Car car2) {
            //return (car1.Name != car2.Name) || (car1.Year != car2.Year);
            return !(car1 == car2);
        }

        public static bool operator >(Car car1, Car car2) {
            return car1.HoursePower > car2.HoursePower;
        }

        public static bool operator <(Car car1, Car car2) {
            return !(car1 > car2);
        }


        public static Car operator +(Car car1, Car car2) {
            return new Car() { Name = "trash" };
        }

        public static explicit operator int(Car car) {
            return car.HoursePower;
        }

        public static implicit operator double (Car car) {
            return car.HoursePower;
        }



        /// <summary>
        /// Improve car's hourse power by 10%
        /// </summary>
        /// <param name="car">our super car</param>
        /// <returns>upgraded car</returns>
        public static Car operator ++(Car car) {
            car.HoursePower += (int)(car.HoursePower / 100.0 * 10);
            return car;
        }

        /*public static bool operator --(Car car) {
            car.HoursePower -= (int)(car.HoursePower / 100.0 * 10);
        }*/
    }
}
