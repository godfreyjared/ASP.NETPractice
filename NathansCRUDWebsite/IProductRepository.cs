using System.Collections.Generic;
using JaredsCRUDWebsite.Models;

namespace JaredsCRUDWebsite
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProduct(int id);
    }
}