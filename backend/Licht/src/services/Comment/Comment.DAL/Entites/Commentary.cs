using LichtDataPack.Interfaces.Entity;

namespace Comment.DAL.Entites
{
    public class Commentary: IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public bool HasAttachment { get; set; }
        public bool HasReplies { get; set; }
    }
}