using Bookmark.DAL.Interfaces.Entity;

namespace Bookmark.DAL.Entities
{
    public class Bookmark: IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PublicationId { get; set; }
        public int TopicId { get; set; }
    }
}