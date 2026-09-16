using Dapper;
using JaredsCRUDWebsite;
using JaredsCRUDWebsite.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Testing
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public string connectionString => throw new NotImplementedException();

        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("Select * From products");

        }
    }
}
