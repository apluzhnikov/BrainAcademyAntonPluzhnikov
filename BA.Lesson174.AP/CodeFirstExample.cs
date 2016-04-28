using DataService;
using DataService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson174.AP
{
    static class CodeFirstExample
    {
        static public void RunExample() {
            using (FlightsManagerDbContext dbContext = new FlightsManagerDbContext())
            {
                Console.WriteLine("Products count: {0}", dbContext.Products.Count());

                /*var product = new Product
                {
                    Currency = new Currency { Name = "EUR", Rate = 0.233m },
                    Name = "test item",
                    Price = 100m
                };

                dbContext.Products.Add(product);
                dbContext.SaveChanges();

                Console.WriteLine("Products count: {0}", dbContext.Products.Count());*/
            }
        }
    }
}
