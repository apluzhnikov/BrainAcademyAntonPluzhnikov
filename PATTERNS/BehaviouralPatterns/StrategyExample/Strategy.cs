using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.BehaviouralPatterns.StrategyExample
{
    static class Strategy
    {
        public static void Run() {
            var product = new Product(10);
            Console.WriteLine($"regular price: {product.RegularPrice}");
            product.SetPricingStrategy(new GoldPricingStrategy());
            Console.WriteLine($"regular price: {product.RegularPrice}");
        }
    }
}
