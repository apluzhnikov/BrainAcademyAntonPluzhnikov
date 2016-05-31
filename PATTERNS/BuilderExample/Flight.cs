using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.BuilderExample
{
    public class Passanger
    {
    }

    public class Plaine
    {
    }

    public class Airline
    {
    }

    public class Flight
    {
        readonly Plaine _plaine;
        IEnumerable<Passanger> _passangers;
        Airline _airline;

        private Flight(Plaine plaine) {
            _plaine = plaine;
        }

        /*//depencies should be transferred in ctor
        public Flight(Plaine plaine, Airline airline = null, IEnumerable<Passanger> passangers = null) {
            _plaine = plaine;
        }*/


        public class Builder
        {
            readonly Flight _flight;
            public Builder(Plaine plaine) {
                _flight = new Flight(plaine);
            }
            public MiddlePartBuilder BuildFirstPart() {
                return new MiddlePartBuilder(_flight);
            }
        }

        public class MiddlePartBuilder
        {
            readonly Flight _flight;
            public MiddlePartBuilder(Flight flight) {
                _flight = flight;
            }

            public MiddlePartBuilder SetPassangers(IEnumerable<Passanger> passangers) {
                _flight._passangers = passangers;
                return this;
            }

            public FinalPartBuilder BuildMiddlePart(IEnumerable<Passanger> passangers = null) {
                return new FinalPartBuilder(_flight);
            }
        }

        public class FinalPartBuilder
        {
            readonly Flight _flight;
            public FinalPartBuilder(Flight flight) {
                _flight = flight;
            }

            public FinalPartBuilder SetAirline(Airline airline) {
                _flight._airline = airline;
                return this;
            }

            public Flight Build() {
                return _flight;
            }

        }

    }
}
