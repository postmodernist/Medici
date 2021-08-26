using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Order.DAL.Entities;
using Order.DAL.Infrastructure;
using Order.DAL.Interfaces.Repositories;

namespace Order.DAL.Repositories
{
    public class OrderRecordRepository: GenericRepository<OrderRecord> , IOrderRepository
    {
        private readonly OrderDbContext _context;
        public OrderRecordRepository(OrderDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<OrderRecord>> GetAllOrderByUserId(int userId)
        {
            var orders = await _context.OrdersRecords.ToListAsync();
            var result = new List<OrderRecord>();
            foreach (var order in orders)
            {
                if (order.UserId == userId)
                    result.Add(order);
            }
            return result;
        }
    }
}