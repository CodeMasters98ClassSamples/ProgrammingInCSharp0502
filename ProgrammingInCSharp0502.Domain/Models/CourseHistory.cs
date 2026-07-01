namespace ProgrammingInCSharp0502.Domain;

public class CourseHistory
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Code { get; set; }
    public decimal Price { get; set; }
    public DateTime StartAt { get; set; }
    public DateTime EndAt { get; set; }
    public CourseType Type { get; set; }
    public Course Course { get; set; }
    public Master Master { get; set; }

}