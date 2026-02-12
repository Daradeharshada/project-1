using System;
using System.Collections.Generic;
using System.Linq;

class Customer
{
    public int CustomerId { get; set; }
    public string CustomerName { get; set; } = "";
}

class Order
{
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public decimal OrderAmount { get; set; }
}

class Program
{
    static void Main()
    {
        List<Customer> customers = new()
        {
            new Customer { CustomerId = 1, CustomerName = "gita" },
            new Customer { CustomerId = 2, CustomerName = "harshu" },
            new Customer { CustomerId = 3, CustomerName = "Sneha" }
        };

        List<Order> orders = new()
        {
            new Order { OrderId = 101, CustomerId = 1, OrderAmount =100 },
            new Order { OrderId = 102, CustomerId = 1, OrderAmount = 1200 },
            new Order { OrderId = 103, CustomerId = 2, OrderAmount = 800 },
            new Order { OrderId = 104, CustomerId = 3, OrderAmount = 300 },
            new Order { OrderId = 105, CustomerId = 3, OrderAmount = 700 }
        };

        var result = customers
            .Join(
                orders,
                c => c.CustomerId,
                o => o.CustomerId,
                (c, o) => new { c.CustomerName, o.OrderId, o.OrderAmount }
            )
            .GroupBy(x => x.CustomerName)
            .Select(g => new
            {
                CustomerName = g.Key,
                OrderCount = g.Count(),
                TotalValue = g.Sum(x => x.OrderAmount),
                Orders = g.Select(x => x.OrderId)
            });

        foreach (var item in result)
        {
            Console.WriteLine($"Customer: {item.CustomerName}");
            Console.WriteLine($"Orders Count: {item.OrderCount}");
            Console.WriteLine($"Total Order Value: {item.TotalValue}");
            Console.WriteLine($"Order IDs: {string.Join(", ", item.Orders)}");
            Console.WriteLine("----------------------------------");
        }
    }
}
