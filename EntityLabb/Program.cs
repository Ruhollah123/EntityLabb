using System.Security.Principal;

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
    public string CourseName { get; set; } = null!;
    public string Describtion { get; set; } = null!;

    public DateTime StartDate { get; set; } 
    public DateTime EndDate { get; set; }
   
}

public class Students
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null !;
}