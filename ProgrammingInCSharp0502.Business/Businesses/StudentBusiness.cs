using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProgrammingInCSharp0502.DataAccess.Data;
using ProgrammingInCSharp0502.Business.Interfaces;
using ProgrammingInCSharp0502.Domain;
using System;
using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace ProgrammingInCSharp0502.Business;

public class StudentBusiness : IStudentBusiness
{
    private readonly CoreDbContext _coreDbContext;

    public StudentBusiness(CoreDbContext coreDbContext)
    {
        _coreDbContext = coreDbContext;
    }

    public List<Student> GetAll()
    {
        var students = _coreDbContext.Students.ToList();
        return students;

    }

    public bool Add(Student student)
    {
        try
        {
           
                _coreDbContext.Students.Add(student);
                int rowsAffected = _coreDbContext.SaveChanges();
                return rowsAffected > 0;
        }
        catch (Exception ex)
        {
            throw ex;
        }
       
    }

    public bool Update(Student student)
    {
        return true;
    }

    public bool Delete(Student student)
    {
        return true;
    }

    public Student GetById(int id)
    {
        throw new NotImplementedException();
    }

    public bool Register()
    {
        throw new NotImplementedException();
    }
}
