using System;
using System.Collections.Generic;
using System.Data;
using Dapper;

namespace DapperClass
{
    public class DepartmentRepository : IDepartmentrepository
    {
        private readonly IDbConnection _conn;

        public DepartmentRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Department> GetDepartments()
        {
            return _conn.Query<Department>("Select * FROM departments;");
        }

        public void CreateDepartment(string name)
        {
            _conn.Execute("INSERT INTO departments Name Values(@name);", new { name = name });
        }

        public void UpdateDepartment(int id, string newName)
        {
            _conn.Execute("UPDATE departments SET Name = @newName WHERE DepartmentID = @id;", new { newName = newName, id = id });
        }
    }

    
}
