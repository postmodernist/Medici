using Catalog.Domain.Interfaces;

namespace Catalog.Domain.Entities
{
    public class Delivery: IEntity
    {
        public int Id { get; set; }
        public string DeliveryType { get; set; }
        public int DeliveryTime { get; set; }
        public decimal DeliveryPrice { get; set; }
    }
}