using System;
using System.Collections.Generic;
using System.Data;
using Dapper;

namespace BestBuyBestPractices
{
    public class DapperDepartmentRepository : IDepartmentRepository
    {
        private readonly IDbConnection _connection;

        public DapperDepartmentRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        // Create GetAllDepartments Method -----
        public IEnumerable<Department> GetAllDepartments()
        {
            return _connection.Query<Department>("Select * From departments;");
        }

        // Create InsertDepartment Method -----
        public void InsertDepartment(string newDepartmentName)
        {
            _connection.Execute("Insert into departments (Name) values (department name);",
            new {departmentName = newDepartmentName});
        }
    }
}
