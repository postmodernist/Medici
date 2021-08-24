using DiscussionBoard.DAL.Interfaces.Entity;

namespace DiscussionBoard.DAL.Entities
{
    public class CommentAttachment:IEntity
    {
        public int Id { get; set; }
        public int ResourceId { get; set; }
        public int CommentId { get; set; }
    }
}