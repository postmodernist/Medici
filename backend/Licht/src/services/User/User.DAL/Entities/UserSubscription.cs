using LichtDataPack.Interfaces.Entity;

namespace User.DAL.Entities
{
    public class UserSubscription: IEntity
    {
        public int Id { get; set; }
        public int SubscriberId { get; set; }
        public int ProducerId { get; set; }
    }
}