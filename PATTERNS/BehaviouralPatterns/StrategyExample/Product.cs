using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.BehaviouralPatterns.StrategyExample
{
    class Product
    {
        private decimal _listPrice;
        IPricingStrategy _pricingStrategy = new DefaultPricingStrategy();

        public Product(decimal listPrice) {
            _listPrice = listPrice;
        }

        public decimal ListPrice => _listPrice;

        public decimal RegularPrice { get { return _pricingStrategy.CalculatePrice(_listPrice); } }

        public void SetPricingStrategy(IPricingStrategy pricingStrategy) {
            _pricingStrategy = pricingStrategy;
        }
    }
}
