namespace LichtDataPack.Dtos.Comments
{
    public class CommentaryReplyDto
    {
        public int Id { get; set; }
        public int CommentaryId { get; set; }
        public int UserId { get; set; }
        public string Reply { get; set; }
    }
}