using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp0502.Domain.Contracts;

internal interface IDeletableEntity
{
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
}
