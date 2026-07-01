namespace ProgrammingInCSharp0502.Domain;

public class StudentCourseHistory
{
    public int Id { get; set; }
    public Student Student { get; set; }
    public CourseHistory CourseHistory { get; set; }
    public PaymentType PaymentType { get; set; }
    public DateTime RegisterDate { get; set; }

}