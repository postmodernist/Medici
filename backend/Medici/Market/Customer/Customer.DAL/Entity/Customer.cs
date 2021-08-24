using Customer.DAL.Interfaces.Entity;

namespace Customer.DAL.Entity
{
    public class Customer: IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string DeliveryCountry { get; set; }
        public string DeliveryAddress { get; set; }
        public bool RecentCustomer { get; set; }
    }
}