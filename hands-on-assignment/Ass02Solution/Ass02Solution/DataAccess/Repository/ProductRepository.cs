using BusinessObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _db;
        public ProductRepository()
        {
            _db = new AppDbContext();
        }

        public void Add(Product product)
        {
                Product p = _db.Products.Find(product.ProductId);
                if (p == null)
                {
                    _db.Products.Add(product);
                    _db.SaveChanges();
            }
            else
            {
                throw new Exception("Product has existed!");
            }
            
        }

        public void DeleteProduct(int productId)
        {
            Product? product = GetProducts().Where(p => p.ProductId == productId).FirstOrDefault();
            if (product != null)
            {
                _db.Products.Remove(product);
                _db.SaveChanges();
            }
            else
                throw new Exception("The product has not existed!");
        }

        public IEnumerable<Product> GetProducts()
        {
            return _db.Products.ToList();
        }

        public IEnumerable<Product> GetProductsByNameId(string? search)
        {
            if (search.IsNullOrEmpty())
            {
                return GetProducts();
            }
            return GetProducts().Where(p => p.ProductId.ToString().Equals(search)
            || p.ProductName.ToLower().Contains(search)).ToList();
        }

        public IEnumerable<Product> GetProductsByUnit(string search)
        {
            if (search.IsNullOrEmpty())
            {
                return GetProducts();
            }
            return GetProducts().Where(p => p.UnitInStock.ToString().Equals(search)
            || p.UnitInStock.ToString().Equals(search)).ToList();
        }

        public void Update(Product product)
        {
            
            Product p = GetProducts().Where(p=>p.ProductId==product.ProductId).FirstOrDefault();
            if (p != null)
            {
                _db.Products.Entry(product).State = EntityState.Detached;
                _db.Set<Product>().Update(product);
                //_db.Products.Update(product);
                _db.SaveChanges();
            }
            else
            {
                throw new Exception("Product is not existed");
            }


        }
    }
}
