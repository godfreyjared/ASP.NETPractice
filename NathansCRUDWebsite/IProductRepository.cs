using JaredsCRUDWebsite.Models;
using System.Collections.Generic;
using Testing.Models;

namespace JaredsCRUDWebsite
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProduct(int id);

        void UpdateProduct(Product product);

        public void InsertProduct(Product productToInsert);
        public IEnumerable<Category> GetCategories();
        public Product AssignCategory();
        public void DeleteProduct(Product product);
    }


}