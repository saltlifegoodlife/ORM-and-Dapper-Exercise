using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper.Models
{
    public class DapperProductRepository : IProductRepository
    {

        private readonly IDbConnection _connection;

        public DapperProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _connection.Query<Product>("SELECT * FROM Products");
        }
        public void CreateProduct(string name, decimal price, int categoryID)
        {
            _connection.Execute("INSERT INTO Products (Name, Price, CategoryID) VALUES (@newName,@newPrice,@newCategoryID);", new { newName = name, newPrice = price, newCategoryID = categoryID });
        }

    }
}
