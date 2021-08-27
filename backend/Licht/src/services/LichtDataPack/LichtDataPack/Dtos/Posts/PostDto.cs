namespace LichtDataPack.Dtos.Posts
{
    public class PostDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
        public bool HasAttachments { get; set; }
    }
}