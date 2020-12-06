using System;
using System.Collections.Generic;
using System.Data;
using Dapper;

namespace DapperClass
{
    public class DapperDepratmentRepository : IDepartmentrepository
    {
        private readonly IDbConnection _connection;
        public DapperDepratmentRepository(IDbConnection connection)
        {
            _connection = connection;
            
        }

        public IEnumerable<Department> GetALlDepartments()
        {
          return _connection.Query<Department>("Select * From departments;");
        }
        public void CreateDepartment(string name)
        {
            _connection.Execute("INSERT INTO departments Name Values(@name);", new { name = name });
        }

        public void UpdateDepartment(int id, string newName)
        {
            _connection.Execute("UPDATE departments SET Name = @newName WHERE DepartmentID = @id;", new { newName = newName, id = id });
        }
    }
}
