using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.BehaviouralPatterns.StrategyExample
{
    interface IPricingStrategy
    {
        decimal CalculatePrice(decimal listPrice);
    }
}
