using Blacklist.DAL.Interfaces.Entity;

namespace Blacklist.DAL.Entity
{
    public class BlacklistRecord: IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BlockedUserId { get; set; }
    }
}