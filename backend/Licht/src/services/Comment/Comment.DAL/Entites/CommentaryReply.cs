using LichtDataPack.Interfaces.Entity;

namespace Comment.DAL.Entites
{
    public class CommentaryReply: IEntity
    {
        public int Id { get; set; }
        public int CommentaryId { get; set; }
        public int UserId { get; set; }
        public string Reply { get; set; }
    }
}