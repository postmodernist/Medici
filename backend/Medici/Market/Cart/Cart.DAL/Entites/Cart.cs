using Cart.DAL.Interfaces.Entity;

namespace Cart.DAL.Entites
{
    public class Cart:IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int TotalPrice { get; set; }
    }
}