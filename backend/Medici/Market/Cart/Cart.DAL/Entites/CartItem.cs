using Cart.DAL.Interfaces.Entity;

namespace Cart.DAL.Entites
{
    public class CartItem: IEntity
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int ItemId { get; set; }
        public int CatalogItemId { get; set; }
    }
}