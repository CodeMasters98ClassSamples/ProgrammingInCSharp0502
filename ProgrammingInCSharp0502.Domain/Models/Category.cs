
using ProgrammingInCSharp0502.Domain.Contracts;

namespace ProgrammingInCSharp0502.Domain;

public class Category : IFullEntity<short>
{
    public short Id { get; set; }
    public string Title { get; set; }
    public DateTime StartAt { get; set; }
    public string Description { get; set; }
    public List<Course> Courses { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
}
