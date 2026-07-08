using ProgrammingInCSharp0502.Domain.Contracts;

namespace ProgrammingInCSharp0502.Domain;
public class Master : IFullEntity<short>
{
    public short Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string NationalCode { get; set; }
    public Address Address { get; set; }
    public string LastDocument { get; set; }
    public string CardInfo { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
}
