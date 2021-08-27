using LichtDataPack.Interfaces.Entity;

namespace Article.DAL.Entities
{
    public class ArticleRecord: IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public int CoverImageId { get; set; }
        //public bool HasAttachments { get; set; }
        public string Content { get; set; }
        public uint Likes { get; set; }
    }
}