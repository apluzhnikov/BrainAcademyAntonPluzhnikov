using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.BehaviouralPatterns.StrategyExample
{
    class GoldPricingStrategy : IPricingStrategy
    {
        const decimal coef = 1.2m;
        public decimal CalculatePrice(decimal listPrice) {
            return listPrice * coef;
        }
    }
}
