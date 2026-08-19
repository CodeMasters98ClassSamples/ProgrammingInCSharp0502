using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProgrammingInCSharp0502.Business.Data;
using ProgrammingInCSharp0502.Business.Interfaces;
using ProgrammingInCSharp0502.Domain;
using System;
using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace ProgrammingInCSharp0502.Business;

public class StudentBusiness : IStudentBusiness
{
    //1. Config -> AppSettings.json , Web.Config , App.Config
    //2. Connection with database -> How many , scale ?
    //3. Next session -> Another way to connect db , EF , Delegate and Event
    string connectionString = "Data Source=.;Initial Catalog=ProgrammingInCSharp0502Db;Integrated Security=True;";

    //Database First -> Connection , 
    //Commands -> Insert , update , delete
    //Query -> Select (Sort, Pagination)
    public List<Student> GetAll()
    {
        CoreDbContext coreDbContext = new CoreDbContext();
        var students = coreDbContext.Students.ToList();
        return students;

        //List<Student> studnets = new List<Student>();
        //try
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        //Connection
        //        connection.Open();

        //        //Query
        //        string query = $"SELECT * FROM dbo.Student WHERE IsDeleted = 0 ORDER BY CreatedAt DESC";
        //        SqlCommand command = new SqlCommand(query, connection);

        //        // Create a data reader to fetch the data
        //        SqlDataReader reader = command.ExecuteReader();

        //        //ORM -> Object Relational Mapping

        //        // Read data and map it to Person objects
        //        while (reader.Read())
        //        {
        //            Student student = new Student(
        //                id: (long)reader["Id"],
        //                firstName: reader["FirstName"].ToString(),
        //                lastName: reader["LastName"].ToString(),
        //                phone: reader["Phone"].ToString(),
        //                nationalCode: reader["NationalCode"].ToString(),
        //                code: reader["Code"].ToString());

        //            studnets.Add(student);
        //        }
        //    }
        //}
        //catch (Exception ex)
        //{
        //    //Log File , Database , ELK
        //    throw;
        //}
        //return studnets;
    }

    public bool Add(Student student)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                //Connection -> Command , Query
                //Connection
                connection.Open();

                // Create a SQL command to insert a new person record
                string query = $"INSERT INTO Student (FirstName, LastName,Phone,NationalCode, Code)" +
                               "VALUES (@FirstName, @LastName,@Phone,@NationalCode,@Code)";
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters to the SQL command
                command.Parameters.AddWithValue("@FirstName", student.FirstName);
                command.Parameters.AddWithValue("@LastName", student.LastName);
                command.Parameters.AddWithValue("@Phone", student.Phone);
                command.Parameters.AddWithValue("@NationalCode", student.NationalCode);
                command.Parameters.AddWithValue("@Code", student.Code);

                // Execute the insert query
                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
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
