using Post.Domain.Interfaces;

namespace Post.Domain.Entities
{
    public class Post: IEntity
    {
        public int Id { get; set; }
        public int CreatorId { get; set; }
        public CreatorType CreatorType { get; set; }
        public string Text { get; set; }
        public bool HasAttachments { get; set; }
        public int Likes { get; set; }
    }

   
}