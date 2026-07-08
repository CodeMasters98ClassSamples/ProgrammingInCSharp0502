using ProgrammingInCSharp0502.Domain.Contracts;

namespace ProgrammingInCSharp0502.Domain;

public class StudentCourseHistory : IEntity<long>, ICreatableEntity
{
    public long Id { get; set; }
    public Student Student { get; set; }
    public CourseHistory CourseHistory { get; set; }
    public PaymentType PaymentType { get; set; }
    public DateTime RegisterDate { get; set; }
    public DateTime CreatedAt { get; set; }
}