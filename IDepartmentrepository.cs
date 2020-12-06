using System;
using System.Collections.Generic;

namespace DapperClass
{
    public interface IDepartmentrepository 
    {
        IEnumerable<Department> GetDepartments();
       

    }
}
