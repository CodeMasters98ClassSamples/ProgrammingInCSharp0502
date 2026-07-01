
namespace ProgrammingInCSharp0502.Domain;

public class Category
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime StartAt { get; set; }
    public string Description { get; set; }
    public List<Course> Courses { get; set; }

}
