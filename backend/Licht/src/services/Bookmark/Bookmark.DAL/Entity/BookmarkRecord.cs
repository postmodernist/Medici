using LichtDataPack.Interfaces.Entity;

namespace Bookmark.DAL.Entity
{
    public class BookmarkRecord: IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TargetId { get; set; }
        public TargetType TargetType { get; set; }
    }
}