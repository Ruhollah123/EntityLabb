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
    public string Description { get; set; } = null!;
    // Navigation property (One-To-Many)

}

public class Courses
{
    public int Id { get; set; }
<<<<<<< HEAD
    public string Name { get; set; }
    public string Description { get; set; }
    // Navigation property (Many-To-One)

}

public class  Students
{
    public  int Id { get; set; }
    public  string FirstName { get; set; }
    public  string LastName { get; set; }
=======
    public string? CourseName  { get; set; }
    public decimal PriceTotal { get; set; }
    // Navigation property (Many-To-One)
    // public Customer Customer { get; set; } = null!;
>>>>>>> 6242eb84a3d9a98913423392b68627d92a7a8f01
}

