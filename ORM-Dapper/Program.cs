using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using ORM_Dapper.Models;
using System.Data;

namespace ORM_Dapper
{
    public class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("DefaultConnection");

            IDbConnection conn = new MySqlConnection(connString);

            var departmentsRepo = new DapperDepartmentRepository(conn);
            var productsRepo = new DapperProductRepository(conn);
            var departments = departmentsRepo.GetAllDepartments();

            foreach (var department in departments)
            {
                Console.WriteLine($"{department.DepartmentID}, {department.Name}");
            }

            Console.WriteLine("Enter new department:");
            var newDep = Console.ReadLine();
            departmentsRepo.InsertDepartment(newDep == null ? "" : newDep) ;
            Console.WriteLine("Added new department....");
            departments = departmentsRepo.GetAllDepartments();
            foreach (var department in departments)
            {
                Console.WriteLine($"{department.DepartmentID}, {department.Name}");
            }

            var products = productsRepo.GetAllProducts();
            Console.WriteLine("-------------------------------------");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.ProductID}, {product.Name}, {product.Price}, {product.CategoryID}");

            }



        }
    }
}
