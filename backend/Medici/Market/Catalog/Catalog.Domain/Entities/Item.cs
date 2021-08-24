using Catalog.Domain.Interfaces;

namespace Catalog.Domain.Entities
{
    public class Item: IEntity
    {
        public int Id { get; set; }
        public int ImageId { get; set; }
        public int DeliveryId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
    }
}