using Microsoft.EntityFrameworkCore;
using ProgrammingInCSharp0502.Domain;

namespace ProgrammingInCSharp0502.Business.Data;

public class CoreDbContext : DbContext
{
    //Database-First: the provider is chosen by the composition root (DI container)

    //Used by the DI container (options are injected by the composition root)
    public CoreDbContext(DbContextOptions<CoreDbContext> options) : base(options)
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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //decimal columns need an explicit precision on SqlServer
        modelBuilder.Entity<Course>().Property(c => c.Price).HasPrecision(18, 2);
        modelBuilder.Entity<CourseHistory>().Property(c => c.Price).HasPrecision(18, 2);

        //SqlServer does not allow multiple cascade paths (cycles between the FKs)
        //-> disable cascade delete on every relationship (ON DELETE NO ACTION)
        //logical delete (IsDeleted) is used in the business layer anyway
        foreach (var foreignKey in modelBuilder.Model.GetEntityTypes()
                     .SelectMany(entityType => entityType.GetForeignKeys()))
        {
            foreignKey.DeleteBehavior = DeleteBehavior.NoAction;
        }
    }
}
