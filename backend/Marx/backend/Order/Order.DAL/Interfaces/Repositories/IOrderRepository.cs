using System.Collections.Generic;
using System.Threading.Tasks;
using Order.DAL.Entities;

namespace Order.DAL.Interfaces.Repositories
{
    public interface IOrderRepository:IGenericRepository<OrderRecord>
    {
        Task<IEnumerable<OrderRecord>> GetAllOrderByUserId(int userId);
    }
}