using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetailsRepository
    {
        IEnumerable<OrderDetail> GetOrderDetails(int id);
        IEnumerable<Object> GetSale();
        IEnumerable<Object> GetSaleAsc();
        void AddNew(OrderDetail detail);
        void Update(OrderDetail detail);
        void Delete(int pid, int oid);
    }
}
