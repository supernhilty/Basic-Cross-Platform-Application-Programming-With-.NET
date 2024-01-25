using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailsRepository : IOrderDetailsRepository
    {
        private readonly AppDbContext _db;
        public OrderDetailsRepository()
        {
            _db = new AppDbContext();
        }

        public void AddNew(OrderDetail detail)
        {
            OrderDetail o = _db.OrderDetails.Where(o => o.OrderId == detail.OrderId && o.ProductId == detail.ProductId).FirstOrDefault();
            if (o!=null) 
            {
                o.Quantity = o.Quantity+detail.Quantity;
                _db.OrderDetails.Update(o);
            }
            else
            {
                _db.OrderDetails.Add(detail);
                _db.SaveChanges();
            }
            
        }

        public void Delete(int pid, int oid)
        {
            _db.OrderDetails.Remove(_db.OrderDetails.Where(o=>o.ProductId==pid&&o.OrderId==oid).FirstOrDefault());
            _db.SaveChanges();
        }

        public IEnumerable<OrderDetail> GetOrderDetails(int id)
        {
            return _db.OrderDetails.Where(o=>o.OrderId == id).ToList();
        }

        public IEnumerable<Object> GetSale()
        {
            /*var list =   _db.OrderDetails
               .GroupBy(o => new { o.ProductId }).ToList()
               .Select(o => new
               {
                   ProductId = o.Key.ProductId,
                   Quantity = o.Sum(o => o.Quantity),
               }).ToList();
           return list;*/
            /*var list = (from o in _db.OrderDetails            
          
            group o by new { o.ProductId } into g
            select new
            {
                Location = g.Key.ProductId,
                Count = g.Select(o => o.Quantity).Sum()
            }).ToList();*/

            var list = _db.OrderDetails
            .GroupBy(x => x.ProductId)
            .Select(g => new { ProductId = g.Key, Sold = g.Sum(x => x.Quantity) }).ToList();
           
            var list2 = (from p in  _db.Products                  
                        select new
                        {
                           ProductId = p.ProductId, 
                           ProductName = p.ProductName,
                           UnitPrice = p.UnitPrice,
                           UnitInStock =p.UnitInStock,
                            
                        }).ToList();
            return (from p in list2 join h in list on p.ProductId equals h.ProductId
                    
                    orderby h.Sold descending
                    select new
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                UnitPrice = p.UnitPrice,
                UnitInStock = p.UnitInStock,
                Sold = h.Sold 
                    }).Distinct().ToList();
        }

        public IEnumerable<object> GetSaleAsc()
        {
            var list = _db.OrderDetails
            .GroupBy(x => x.ProductId)
            .Select(g => new { ProductId = g.Key, Sold = g.Sum(x => x.Quantity) }).ToList();

            var list2 = (from p in _db.Products
                         select new
                         {
                             ProductId = p.ProductId,
                             ProductName = p.ProductName,
                             UnitPrice = p.UnitPrice,
                             UnitInStock = p.UnitInStock,

                         }).ToList();
            return (from p in list2
                    join h in list on p.ProductId equals h.ProductId
                    orderby h.Sold
                    select new
                    {
                        ProductId = p.ProductId,
                        ProductName = p.ProductName,
                        UnitPrice = p.UnitPrice,
                        UnitInStock = p.UnitInStock,
                        Sold = h.Sold
                    }).Distinct().ToList();
        }

        public void Update(OrderDetail detail)
        {
            _db.OrderDetails.Update(detail);
            _db.SaveChanges();
        }
    }
}
