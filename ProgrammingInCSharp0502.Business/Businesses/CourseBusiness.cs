using ProgrammingInCSharp0502.Business.Interfaces;
using ProgrammingInCSharp0502.DataAccess.Data;
using ProgrammingInCSharp0502.Domain;

namespace ProgrammingInCSharp0502.Business.Businesses;

public class CourseBusiness : IBusiness<Course>
{
    private readonly CoreDbContext _coreDbContext;

    public CourseBusiness(CoreDbContext coreDbContext)
    {
        _coreDbContext = coreDbContext;
    }
    public bool Add(Course item)
    {
        _coreDbContext.Courses.Add(item);
        int rowsAffected = _coreDbContext.SaveChanges();
        return rowsAffected > 0;
    }

    public bool Delete(Course item)
    {
        throw new NotImplementedException();
    }

    public List<Course> GetAll()
    {
        return _coreDbContext.Courses.ToList();
    }

    public Course GetById(int id)
    {
        throw new NotImplementedException();
    }

    public bool Update(Course item)
    {
        throw new NotImplementedException();
    }
}
