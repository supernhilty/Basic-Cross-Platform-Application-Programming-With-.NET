using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetOrders();
        IEnumerable<Order> GetOrders(int memberId);
        IEnumerable<Order> GetOrdersByDate(DateTime start, DateTime end);
        void UpdateOrder(Order order);
        void AddOrder(Order order);
        void DeleteOrder(int id);
    }
}
