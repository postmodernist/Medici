using Friend.DAL.Infrastructure.Entity;

namespace Friend.DAL.Entities
{
    public class Friend: IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FriendId { get; set; }
    }
}