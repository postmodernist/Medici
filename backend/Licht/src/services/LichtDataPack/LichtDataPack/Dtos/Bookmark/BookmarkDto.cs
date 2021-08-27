namespace LichtDataPack.Dtos.Bookmark
{
    public class BookmarkDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TargetId { get; set; }
        public TargetType TargetType { get; set; }
    }
}