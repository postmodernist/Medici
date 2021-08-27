using System.Collections.Generic;
using System.Threading.Tasks;
using Order.DAL.Entities;

namespace Order.BLL.Intefaces
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderRecord>> GetAllOrdersByUserIdAsync(int userId);
        Task<IEnumerable<OrderRecord>> GetAllOrders();
        Task<OrderRecord> GetOrder(int id);
        Task<OrderRecord> AddOrder(OrderRecord order);
        Task<OrderRecord> UpdateOrder(OrderRecord order);
        Task<OrderRecord> DeleteOrder(int id);
    }
}