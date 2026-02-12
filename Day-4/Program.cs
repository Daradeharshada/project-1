// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
public class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }

    public Order PlaceOrder(Product product)
    {
        // Implementation
        return new Order { OrderId = 1, Product = product, Customer = this };
    }
}

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class Order
{
    public int OrderId { get; set; }
    public Product Product { get; set; }
    public Customer Customer { get; set; }
    public PaymentStatus PaymentStatus { get; set; }
}

public enum PaymentStatus
{
    Pending,
    Paid,
    Failed
}

public class PaymentGateway
{
    public void ProcessPayment(Order order)
    {
        // Implementation
        order.PaymentStatus = PaymentStatus.Paid;
    }
}

public class Seller
{
    public void ShipProduct(Order order)
    {
        // Implementation
        Console.WriteLine($"Shipping product {order.Product.Name} to customer {order.Customer.Name}");
    }
}

class Program
{
    static void Main()
    {
        Customer customer = new Customer { CustomerId = 1, Name = "John Doe" };
        Product product = new Product { ProductId = 1, Name = "Laptop", Price = 50000.0m };
        Order order = customer.PlaceOrder(product);

        PaymentGateway paymentGateway = new PaymentGateway();
        paymentGateway.ProcessPayment(order);

        Seller seller = new Seller();
        seller.ShipProduct(order);
    }
}