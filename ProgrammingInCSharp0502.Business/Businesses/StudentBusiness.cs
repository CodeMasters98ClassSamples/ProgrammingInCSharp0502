using Microsoft.EntityFrameworkCore;
using ProgrammingInCSharp0502.Business.Data;
using ProgrammingInCSharp0502.Business.Interfaces;
using ProgrammingInCSharp0502.Domain;

namespace ProgrammingInCSharp0502.Business.Businesses;

/// <summary>
/// Database-First approach:
/// works on CoreDbContext (registered with the EF Core InMemory provider by the DI container).
/// The context is injected -> the business layer never creates its own dependencies.
/// </summary>
public class StudentBusiness : IStudentBusiness
{
    private readonly CoreDbContext _context;

    public StudentBusiness(CoreDbContext context)
    {
        _context = context;
    }

    public bool Add(Student item)
    {
        item.CreatedAt = DateTime.Now;
        _context.Students.Add(item);
        return _context.SaveChanges() > 0;
    }

    public bool Update(Student item)
    {
        _context.Students.Update(item);
        return _context.SaveChanges() > 0;
    }

    public bool Delete(Student item)
    {
        //Logical delete (حذف منطقی)
        item.IsDeleted = true;
        item.DeletedAt = DateTime.Now;
        return Update(item);
    }

    public Student GetById(int id)
    {
        return _context.Students.AsNoTracking()
            .FirstOrDefault(s => s.Id == id && !s.IsDeleted);
    }

    public List<Student> GetAll()
    {
        return _context.Students.AsNoTracking()
            .Where(s => !s.IsDeleted)
            .OrderByDescending(s => s.CreatedAt)
            .ToList();
    }

    public bool Register()
    {
        //TODO: register the student on a course (StudentCourseHistory)
        throw new NotImplementedException();
    }
}
