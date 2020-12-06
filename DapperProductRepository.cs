using System;
using System.Collections.Generic;
using System.Data;
using Dapper;

namespace DapperClass
{
    public class DapperProductRepository : IProductRepository
    {
        private readonly IDbConnection _connection;
        public DapperProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public void CreateProduct (string)
        public IEnumerable<Products> GetAllProducts()
        {
            return _connection.Query<Products>("Select * From Products;");
        }

        
    }
}
