using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;

namespace DapperClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("DefualtConnection");
            IDbConnection conn = new MySqlConnection(connString);

            var repo = new DapperDepratmentRepository(conn);

            var departments = repo.GetALlDepartments();

            foreach(var dept in departments)
            {
                Console.WriteLine($"{ dept.DepartmentId} { dept.Name}");
            }


            var repoProd = new DapperProductRepository(conn);

            var products = repoProd.GetAllProducts();

            foreach (var prod in products)
            {
                Console.WriteLine($"{prod.CetegoryId} {prod.ProductId} {prod.Name} {prod.Price} { prod.OnSale} { prod.StockLevel}");
                
            }
          

        }
    }
}
