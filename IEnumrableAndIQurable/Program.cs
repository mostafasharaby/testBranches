using Microsoft.EntityFrameworkCore;

public class Product
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; }
}

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=TestIEnumrable;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;");
    }
}

class Program
{
    static void Main()
    {
        using (var context = new AppDbContext())
        {
            // Using IQueryable - Filtering happens in the database (SQL)
            //IQueryable<Product> queryableProducts = context.Products.Where(p => p.UnitPrice > 300);
            //Console.WriteLine("IQueryable executed SQL query:");
            //foreach (var product in queryableProducts)
            //{
            //    Console.WriteLine($"Product: {product.ProductName}, Price: {product.UnitPrice}");
            //}

            // Using IEnumerable - Fetches all data into memory first, then filters
            IEnumerable<Product> enumerableProducts = context.Products.ToList().Where(p => p.UnitPrice > 300);
            Console.WriteLine("\nIEnumerable executed in-memory filtering:");
            foreach (var product in enumerableProducts)
            {
                Console.WriteLine($"Product: {product.ProductName}, Price: {product.UnitPrice}");
            }
        }
    }
}
/*
 Example: LINQ-to-Objects
Since IEnumerable<T> works with in-memory data, it allows you to apply LINQ directly on collections.

✅ Querying a List (No Database)
csharp
Copy
Edit
List<Product> products = new List<Product>
{
    new Product { ProductID = 1, ProductName = "Laptop", UnitPrice = 1200 },
    new Product { ProductID = 2, ProductName = "Mouse", UnitPrice = 30 },
    new Product { ProductID = 3, ProductName = "Monitor", UnitPrice = 250 }
};

// LINQ-to-Objects (Filtering products priced above $100)
IEnumerable<Product> expensiveProducts = products.Where(p => p.UnitPrice > 100);

// Print results
foreach (var product in expensiveProducts)
{
    Console.WriteLine($"{product.ProductName} - ${product.UnitPrice}");
}
🔹 Output:

nginx
Copy
Edit
Laptop - $1200
Monitor - $250
 */