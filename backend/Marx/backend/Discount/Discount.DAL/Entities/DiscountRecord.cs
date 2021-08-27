using Discount.DAL.Interfaces;

namespace Discount.DAL.Entities
{
    public class DiscountRecord:IEntity
    {
        public int Id { get; set; }
        public int CatalogItemId { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
    }
}