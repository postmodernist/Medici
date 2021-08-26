using LichtDataPack.Interfaces;

namespace Article.DAL.Entities
{
    public class Article: IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public int CoverImageId { get; set; }
        //public bool HasAttachments { get; set; }
        public string Content { get; set; }

    }
}