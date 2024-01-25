using BusinessObject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _db;
        public OrderRepository()
        {
            _db = new AppDbContext();
        }

        public void AddOrder(Order order)
        {
            _db.Orders.Add(order);
            _db.SaveChanges();
        }

        public void DeleteOrder(int id)
        {
            try
            {
                _db.Orders.Remove(_db.Orders.Where(o => o.OrderId == id).FirstOrDefault());
                foreach (var item in _db.OrderDetails.Where(o => o.OrderId == id))
                {
                    _db.OrderDetails.Remove(item);
                }
                _db.SaveChanges();
            }
            catch(Exception ex)
            {

            }
            
           
        }

        public IEnumerable<Order> GetOrders()
        {
            return _db.Orders.ToList();
        }

        public IEnumerable<Order> GetOrders(int memberId)
        {
            return _db.Orders.Where(o=>o.MemberId==memberId).ToList();
        }

        public IEnumerable<Order> GetOrdersByDate(DateTime start, DateTime end)
        {
            if (end < start) throw new Exception("End date must after or equal start date!");
            return GetOrders().Where(mem=>mem.OrderDate>=start&&mem.OrderDate<=end).ToList();
        }

        public void UpdateOrder(Order order)
        {
           
                _db.Orders.Update(order);
                _db.SaveChanges();
           
        }
    }
}
