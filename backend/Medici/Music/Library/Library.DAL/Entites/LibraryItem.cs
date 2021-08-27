using Library.DAL.Interfaces.Entity;

namespace Library.DAL.Entites
{
    public class LibraryItem: IEntity
    {
        public int Id { get; set; }
        public int LibraryId { get; set; }
        public int SongId { get; set; }
        public int AlbumId { get; set; }
        public int ArtistId { get; set; }
    }
}