using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProgrammingInCSharp0502.Domain;

namespace ProgrammingInCSharp0502.DataAccess.Data;

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
        //=> options.UseSqlServer("Data Source=NIKZAD\\TUTORIAL;Initial Catalog=ProgrammingInCSharp0502Db;Integrated Security=True;TrustServerCertificate=True;");
    => options.UseSqlServer("Data Source=NIKZAD\\TUTORIAL;Initial Catalog=ProgrammingInCSharp0502Db-2;Integrated Security=True;TrustServerCertificate=True;");


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //fluent api
        modelBuilder.Entity<StudentCourseHistory>()
            .HasOne(sch => sch.Student)
            .WithMany()
            .HasForeignKey(sch => sch.StudentId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
