using System.Collections.Generic;
using Feed.Domain.Interfaces;

namespace Feed.Domain.Entities
{
    public class FeedList: IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public IEnumerable<FeedItem> FeedItems { get; set; }
    }
}