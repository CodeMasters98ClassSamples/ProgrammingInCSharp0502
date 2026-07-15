using ProgrammingInCSharp0502.Domain.Contracts;

namespace ProgrammingInCSharp0502.Domain;
public class Course : IFullEntity<short>
{
    public short Id { get; set; } //PK
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Hour { get; set; }
    public int OnSiteSize { get; set; }
    public int RemoteSize { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
}
