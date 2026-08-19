using Microsoft.EntityFrameworkCore;
using ProgrammingInCSharp0502.Domain;

namespace ProgrammingInCSharp0502.Business.Data;

public class CoreDbContext : DbContext
{
    public CoreDbContext()
    {
        //
    }

    public DbSet<Address> Addresses { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Master> Masters { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<CourseHistory> CourseHistories { get; set; }
    public DbSet<StudentCourseHistory> StudentCourseHistories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Data Source=.;Initial Catalog=ProgrammingInCSharp0502Db-2;Integrated Security=True;");
}
