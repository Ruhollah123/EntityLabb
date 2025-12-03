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
<<<<<<< HEAD
<<<<<<< HEAD
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
=======
=======
>>>>>>> e82498cf9428ddcc0e5ec1b04cfc7e6922954470
    public string CourseName { get; set; } = null!;
    public string Describtion { get; set; } = null!;

    public DateTime StartDate { get; set; } 
    public DateTime EndDate { get; set; }
   

}


