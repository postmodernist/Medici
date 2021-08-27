using Article.Domain.Interfaces;

namespace Article.Domain.Entities
{
    public class Article: IEntity
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public int ImageAlbumId { get; set; }
        public int CoverImageId { get; set; }
        public string CoverImageUri { get; set; }
        public string Text { get; set; }
        public int Likes { get; set; }
    }
}