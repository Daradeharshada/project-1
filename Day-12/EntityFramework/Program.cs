using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;

// =======================
// MAIN PROGRAM
// =======================

try
{
    using (var _context = new CrmContext())
    {
        // ✅ Add New Customer
        var newCustomer = new Customer
        {
            FirstName = "Amit",
            LastName = "Sharma",
            Email = "amit.sharma@gmail.com",
            Phone = "9999999999",
            City = "Delhi"
        };

        _context.Customers.Add(newCustomer);
        _context.SaveChanges();

        // ✅ Add Order for that Customer
        var newOrder = new Order
        {
            OrderDate = DateTime.Now,
            Amount = 1500,
            CustomerId = newCustomer.CustomerId
        };

        _context.Orders.Add(newOrder);
        _context.SaveChanges();

        // ✅ Fetch and Display Customers
        var customers = _context.Customers.ToList();

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine($"{"ID",-5} {"FirstName",-12} {"LastName",-12} {"Email",-25} {"City",-10}");
        Console.WriteLine("----------------------------------------------------------------------------");

        foreach (var customer in customers)
        {
            Console.WriteLine($"{customer.CustomerId,-5} {customer.FirstName,-12} {customer.LastName,-12} {customer.Email,-25} {customer.City,-10}");
        }

        Console.WriteLine("----------------------------------------------------------------------------");
    }
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
    if (ex.InnerException != null)
        Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
}


// =======================
// DB CONTEXT
// =======================

public class CrmContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost;Database=CRMDB;Trusted_Connection=True;TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("custTable");
            entity.HasKey(e => e.CustomerId);

            entity.Property(e => e.FirstName).IsRequired().HasMaxLength(50);
            entity.Property(e => e.LastName).IsRequired().HasMaxLength(50);
            entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
            entity.Property(e => e.Phone).HasMaxLength(15);
            entity.Property(e => e.City).HasMaxLength(50);

            entity.Property(e => e.CreatedDate)
                  .HasDefaultValueSql("GETDATE()")
                  .ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId);

            entity.Property(e => e.Amount)
                  .HasColumnType("decimal(18,2)");

            entity.HasOne(o => o.Customer)
                  .WithMany(c => c.Orders)
                  .HasForeignKey(o => o.CustomerId);
        });
    }
}

public class Order
{
    [Key]
    public int OrderId { get; set; }

    [Required]
    [MaxLength(100)]
    [MinLength(3)]
    public string Product { get; set; }

    [Required]
    [Precision(18, 2)]
    public decimal Price { get; set; }

    [ForeignKey("CustomerId")]
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
}
public class Customer
{
    public int CustomerId { get; set; }

    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;

    public DateTime? CreatedDate { get; set; }

    public List<Order> Orders { get; set; } = new List<Order>();
}


// =======================
// ORDER ENTITY
// =======================

public class Order
{    [key] 
    public int OrderId { get; set; }

    public DateTime OrderDate { get; set; }

    public decimal Amount { get; set; }

    public int CustomerId { get; set; }

    public Customer Customer { get; set; }
}
