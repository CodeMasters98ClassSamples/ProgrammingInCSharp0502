using ProgrammingInCSharp0502.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp0502.Business.Interfaces;

internal interface IStudentBusiness : IBusiness<Student>
{
    bool Register();
}
