using BA.Lesson15.AP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class SerializerTest
    {
        public Flight GetFlight() => new Flight
            {
                Number = 1,
                City = "London",
                Status = Status.Unknown
            };

        public Flight[] GetFlights() =>
            new Flight[]
            {
                new Flight {Number = 1,City="London", Status = Status.Unknown },
                new Flight {Number = 2,City="Berlin", Status = Status.Delayed },
                new Flight {Number = 3,City="Dublin", Status = Status.Canceled },
                new Flight {Number = 4,City="Kharkiv", Status = Status.Arrived }
            };

    }
}
