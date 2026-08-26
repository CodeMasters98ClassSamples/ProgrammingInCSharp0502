using Microsoft.EntityFrameworkCore;
using ProgrammingInCSharp0502.Business.Data;
using ProgrammingInCSharp0502.Business.Interfaces;
using ProgrammingInCSharp0502.Domain;

namespace ProgrammingInCSharp0502.Business.Businesses;

/// <summary>
/// Database-First approach:
/// works on CoreDbContext (registered with the EF Core InMemory provider by the DI container).
/// </summary>
public class CourseDatabaseFirstBusiness : ICourseBusiness
{
    private readonly CoreDbContext _context;

    public CourseDatabaseFirstBusiness(CoreDbContext context)
    {
        _context = context;
    }

    public bool Add(Course item)
    {
        item.CreatedAt = DateTime.Now;
        _context.Courses.Add(item);
        return _context.SaveChanges() > 0;
    }

    public bool Update(Course item)
    {
        _context.Courses.Update(item);
        return _context.SaveChanges() > 0;
    }

    public bool Delete(Course item)
    {
        //Logical delete (حذف منطقی)
        item.IsDeleted = true;
        item.DeletedAt = DateTime.Now;
        return Update(item);
    }

    public Course GetById(int id)
    {
        return _context.Courses.AsNoTracking()
            .FirstOrDefault(c => c.Id == id && !c.IsDeleted);
    }

    public List<Course> GetAll()
    {
        return _context.Courses.AsNoTracking()
            .Where(c => !c.IsDeleted)
            .OrderByDescending(c => c.CreatedAt)
            .ToList();
    }
}
