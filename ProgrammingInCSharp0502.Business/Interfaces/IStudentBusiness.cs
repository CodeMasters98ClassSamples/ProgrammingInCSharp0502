using ProgrammingInCSharp0502.Domain;

namespace ProgrammingInCSharp0502.Business.Interfaces;

internal interface IStudentBusiness : IBusiness<Student>
{
    bool Register();
}
