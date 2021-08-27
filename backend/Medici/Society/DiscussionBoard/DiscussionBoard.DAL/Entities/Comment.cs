using DiscussionBoard.DAL.Interfaces.Entity;

namespace DiscussionBoard.DAL.Entities
{
    public class Comment: IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BoardId { get; set; }
        public string Text { get; set; }
        public bool HasAttachments { get; set; }
    }
}