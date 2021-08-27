using LichtDataPack.Interfaces.Entity;

namespace Posts.DAL.Entities
{
    public class Post:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
        public bool HasAttachments { get; set; }
    }
}