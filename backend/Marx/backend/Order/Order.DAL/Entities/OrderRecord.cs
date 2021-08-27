using System;
using Order.DAL.Interfaces.Entity;

namespace Order.DAL.Entities
{
    public class OrderRecord: IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CartId { get; set; }
        public DateTime OrderDateTime { get; set; }
        public decimal TotalPrice { get; set; }
        public string DeliverAddress { get; set; }
    }
}