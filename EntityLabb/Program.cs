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


public class Education
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Beskrivning { get; set; } = null!;
    // Navigation property (One-To-Many)

}
public class Courses
{
    public int Id { get; set; }
    public string  { get; set; }
    public decimal PriceTotal { get; set; }
    // Navigation property (Many-To-One)
    public Customer Customer { get; set; } = null!;
}

