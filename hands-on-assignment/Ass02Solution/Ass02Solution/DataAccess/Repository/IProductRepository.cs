using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        IEnumerable<Product> GetProductsByNameId(string search);
        IEnumerable<Product> GetProductsByUnit(string search);
        void DeleteProduct(int productId);
        void Add(Product product);
        void Update(Product product);
    }
}
