using Newtonsoft.Json;
using ProgrammingInCSharp0502.MyWindowsformApp.Models;


namespace ProgrammingInCSharp0502.MyWindowsformApp.Businesses;

public class StudentBusiness
{
    public List<Student> GetStudents()
    {
        //From Object
        //return new List<Student>();
        List<Student> students = new();

        string jsonDataStr = string.Empty;
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "StudentsData.json");
        if (File.Exists(filePath))
        {
            jsonDataStr = File.ReadAllText(filePath);
            if (!string.IsNullOrEmpty(jsonDataStr))
            {
                students = JsonConvert.DeserializeObject<List<Student>>(jsonDataStr);
         
            }
        }
        return students;
    }
}
