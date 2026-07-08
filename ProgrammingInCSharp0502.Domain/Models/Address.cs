using ProgrammingInCSharp0502.Domain.Contracts;

namespace ProgrammingInCSharp0502.Domain;

public class Address : IFullEntity<int>
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Detail { get; set; }
    public string PostalCode { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
}
