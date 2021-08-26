using System.Collections.Generic;
using System.Threading.Tasks;
using Order.BLL.Intefaces;
using Order.DAL.Entities;
using Order.DAL.Interfaces.Repositories;

namespace Order.BLL.Services
{
    public class OrderService: IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<IEnumerable<OrderRecord>> GetAllOrdersByUserIdAsync(int userId)
        {
            return await _orderRepository.GetAllOrderByUserId(userId);
        }

        public async Task<IEnumerable<OrderRecord>> GetAllOrders()
        {
            return await _orderRepository.GetAll();
        }

        public async Task<OrderRecord> GetOrder(int id)
        {
            return await _orderRepository.GetById(id);
        }

        public async Task<OrderRecord> AddOrder(OrderRecord order)
        { 
            return  await _orderRepository.Add(order);
        }

        public async Task<OrderRecord> UpdateOrder(OrderRecord order)
        {
            return await _orderRepository.Update(order);
        }

        public async Task<OrderRecord> DeleteOrder(int id)
        {
            return await _orderRepository.Delete(id);
        }
    }
}