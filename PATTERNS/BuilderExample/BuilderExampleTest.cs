using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.BuilderExample
{
    static class BuilderExampleTest
    {
        static public void Run() {
            //Flight flight = new Flight(new Plaine());
            var builder1 = 
                new Flight.Builder(new Plaine())
                .BuildFirstPart()
                .BuildMiddlePart()
                .Build();
            var builder2 = 
                new Flight.Builder(new Plaine())
                .BuildFirstPart()
                .BuildMiddlePart(new List<Passanger> { new Passanger(), new Passanger() })
                .Build();

            var builder3 =
                new Flight.Builder(new Plaine())
                .BuildFirstPart()
                .BuildMiddlePart(new List<Passanger> { new Passanger(), new Passanger() })
                .SetAirline(new Airline())
                .Build();

        }
    }
}
