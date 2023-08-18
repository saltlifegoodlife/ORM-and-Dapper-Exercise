using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper.Models
{
    internal interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();

        public void CreateProduct(string name, decimal price, int categoryID);

    }
}
