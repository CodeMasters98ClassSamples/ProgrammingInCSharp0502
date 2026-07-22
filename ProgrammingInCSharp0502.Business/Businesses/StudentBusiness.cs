using Newtonsoft.Json;
using ProgrammingInCSharp0502.Business.Interfaces;
using ProgrammingInCSharp0502.Domain;
using System;
using System.Data.SqlClient;

namespace ProgrammingInCSharp0502.Business;

public class StudentBusiness : IStudentBusiness
{
    string connectionString = "Data Source=.;Initial Catalog=ProgrammingInCSharp0502Db;Integrated Security=True;";

    //Database First -> Connection , 
    //Commands -> Insert , update , delete
    //Query -> Select (Sort, Pagination)
    public List<Student> GetAll()
    {
        List<Student> studnets = new List<Student>();
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Connection
                connection.Open();

                //Query
                string query = $"SELECT * FROM dbo.Student ORDER BY CreatedAt DESC";
                SqlCommand command = new SqlCommand(query, connection);

                // Create a data reader to fetch the data
                SqlDataReader reader = command.ExecuteReader();

                // Read data and map it to Person objects
                while (reader.Read())
                {
                    Student student = new Student(
                        id: (long)reader["Id"],
                        firstName: reader["FirstName"].ToString(),
                        lastName: reader["LastName"].ToString(),
                        phone: reader["Phone"].ToString(),
                        nationalCode: reader["NationalCode"].ToString(),
                        code: reader["Code"].ToString());

                    studnets.Add(student);
                }
            }
        }
        catch (Exception ex)
        {
            //Log File , Database , ELK
            throw;
        }
        return studnets;
    }

    public bool Add(Student student)
    {
        //CAP -> Network Issue
        //Sql Server , File , MySql ,..

        return true;
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
