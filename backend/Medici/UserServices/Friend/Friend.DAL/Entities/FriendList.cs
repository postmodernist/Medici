using System.Collections.Generic;
using Friend.DAL.Infrastructure.Entity;

namespace Friend.DAL.Entities
{
    public class FriendList: IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public IEnumerable<Friend> Friends { get; set; }
    }
}