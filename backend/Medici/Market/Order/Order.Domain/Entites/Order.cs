using System;
using Order.Domain.Interfaces;

namespace Order.Domain.Entites
{
    public class Order:IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int CartId { get; set; }
        public int DeliveryId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
    }
}