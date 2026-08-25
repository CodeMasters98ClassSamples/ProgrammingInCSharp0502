using ProgrammingInCSharp0502.Business.Interfaces;
using ProgrammingInCSharp0502.DataAccess.Data;
using ProgrammingInCSharp0502.Domain;

namespace ProgrammingInCSharp0502.Business.Businesses
{
    public class CategoryBusiness : ICategoryBusiness
    {
        private readonly CoreDbContext _coreDbContext;

        public CategoryBusiness(CoreDbContext coreDbContext)
        {
            _coreDbContext = coreDbContext;
        }
        public bool Add(Category item)
        {
            _coreDbContext.Categories.Add(item);
            int rowsAffected = _coreDbContext.SaveChanges();
            return rowsAffected > 0;
        }

        public bool Delete(Category item)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return _coreDbContext.Categories.ToList();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Category item)
        {
            throw new NotImplementedException();
        }
    }
}
