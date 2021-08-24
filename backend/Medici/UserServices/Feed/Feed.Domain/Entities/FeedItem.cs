using Feed.Domain.Interfaces;

namespace Feed.Domain.Entities
{
    public class FeedItem: IEntity
    {
        public int Id { get; set; }
        public int FeedId { get; set; }
        public int PublicationId { get; set; }
    }
}