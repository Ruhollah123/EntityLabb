namespace EntityLabb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}


public class Customer
{
    public int Id { get; set; }
    public string CompanyName { get; set; } = null!;
    public string City { get; set; } = null!;
    // Navigation property (One-To-Many)
    public List<Order> Orders { get; set; } = null!;
}
public class Order
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public decimal PriceTotal { get; set; }
    // Navigation property (Many-To-One)
    public Customer Customer { get; set; } = null!;
}