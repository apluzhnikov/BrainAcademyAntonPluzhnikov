using BA.Lesson131.AP.Animal;
using BA.Lesson131.AP.Animal.Exceptions;
using BA.Lesson131.AP.Animal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson131.AP
{
    class Program
    {
        static Random rand = new Random((int)DateTime.Now.Ticks);
        static void Main(string[] args) {

            IBird[] birds = new IBird[rand.Next(10, 20)];

            for (int i = 0; i < birds.Length; i++)
            {
                IBird bird = null;
                var nextRand = rand.Next(0, 30);
                if (nextRand > 20)
                    bird = new Eagle();
                else if (nextRand > 10)
                    bird = new Lark();
                else
                    bird = new Sparrow();

                bird.CurrentSpeed = rand.Next(10, (int)bird.MaxSpeed - 1) + rand.NextDouble() ;

                birds[i] = bird;
            }

            foreach (IBird bird in birds)
            {
                Console.WriteLine("==============================================================================");
                try
                {
                    var speedAcceleration = rand.Next(1, 100);
                    Console.WriteLine("Current speed for {0} is {1}, the wind speed is {2}", bird.Name, bird.CurrentSpeed, speedAcceleration);
                    bird.FlyWithinWind(speedAcceleration);
                    Console.WriteLine("After windy weather the bird is Alive");
                }
                catch (BirdFlewAwayException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            Console.ReadLine();

        }
    }

    #region info about exceptions

    /*class Demo
    {
        public void OutterMethod() {
            try
            {
                InnerMethod();
            }
            catch(ArgumentException ex)
            {
                Debug.WriteLine(ex.ToString());
                //throw new ArgumentException(); // bad to do, because in this case the start point for an exception will be here, not in real place
                throw;//standart thing if need to throw an exception
                //throw new YourException("if need a full stack trace info with additional info then put this + original exception ->", ex);
            }
            catch (Exception ex) { }//basically you do not need to catch general exception!!!!! bad practice
        }

        public void InnerMethod() {
            throw new ArgumentException();
        }
    }*/
    #endregion
}
