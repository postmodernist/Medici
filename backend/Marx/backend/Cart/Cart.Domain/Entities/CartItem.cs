using Cart.Domain.Interfaces;

namespace Cart.Domain.Entities
{
    public class CartItem: IEntity
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int CatalogItemId { get; set; }
        public int Amount { get; set; }
    }
}