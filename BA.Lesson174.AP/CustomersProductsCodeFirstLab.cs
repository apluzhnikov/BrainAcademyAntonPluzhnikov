using DataService;
using DataService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson174.AP
{
    static class CustomersProductsCodeFirstLab
    {
        static Random rand = new Random();
        static public void RunExample() {
            using (CustomersProductsDBContext dbContext = new CustomersProductsDBContext())
            {
                Console.WriteLine("Products count: {0}", dbContext.Products.Count());

                if (dbContext.CustomersProducts.Count() == 0)
                    AddInfo(dbContext);

                var CustomersQuery = dbContext.
                    Customers
                    .Select(arg => new {
                        FirstName = arg.FirstName,
                        Qty = arg.CustomersProducts.Sum(sum => sum.Qty),
                        Total = arg.CustomersProducts.Sum(sum => sum.Qty * sum.Product.Price)
                    })
                    .OrderByDescending(arg => arg.Total)
                    ;

                var CustomersMostExpensiveChequeQuery = dbContext.Customers
                    .Select(arg => new {
                        FirstName = arg.FirstName,                        
                        Price = arg.CustomersProducts.Max(sum => sum.Qty * sum.Product.Price)
                    })
                    .OrderByDescending(arg => arg.Price)
                    ;

                var reachestCustomer = CustomersQuery.First();
                var customerWithNoByus = CustomersQuery.FirstOrDefault(arg => arg.Qty == 0);
                var CustomerMostExpensiveCheque = CustomersMostExpensiveChequeQuery.First();



                Console.WriteLine("Customer {0} bought {1} items and payed {2} dollars ", reachestCustomer.FirstName, reachestCustomer.Qty, reachestCustomer.Total);
                if (customerWithNoByus != null)
                    Console.WriteLine("Customer {0} bought 0 items ", customerWithNoByus.FirstName);

                Console.WriteLine("Customer {0} payed more than any for one check. His total is {1}", CustomerMostExpensiveCheque.FirstName, CustomerMostExpensiveCheque.Price);


            }
        }

        private static void AddInfo(CustomersProductsDBContext dbContext) {

            var customersCount = rand.Next(0, 20);
            for (int i = 0; i <= customersCount; i++)
            {
                var customer = new Customer
                {
                    FirstName = "FirstName #" + i,
                    LastName = "LastName #" + i,
                    PhoneNumber = rand.Next(1000000, 9000000).ToString()
                };

                var productsCount = rand.Next(10, 30);

                for (int y = 0; y <= productsCount; y++)
                {
                    var customerProduct = new CustomersProducts
                    {
                        Product = new Product
                        {
                            Name = "First Test Product #" + y,
                            Price = rand.Next(50, 200)
                        },
                        Customer = customer,
                        Qty = rand.Next(0, 100)
                    };
                    dbContext.CustomersProducts.Add(customerProduct);
                }
            }
            dbContext.SaveChanges();
        }
    }
}
