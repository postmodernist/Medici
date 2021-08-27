namespace LichtDataPack.Dtos.Comments
{
    public class CommentaryDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public bool HasAttachment { get; set; }
        public bool HasReplies { get; set; }
    }
}