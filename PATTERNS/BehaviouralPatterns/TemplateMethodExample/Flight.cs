using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.BehaviouralPatterns.TemplateMethodExample
{
    class Flight
    {
        string _number;
        string _airline;
        public Flight(string number, string airline) {
            _number = number;
            _airline = airline;
        }

        public override string ToString() => $"number: {_number}, airline: {_airline}";


    }
}
