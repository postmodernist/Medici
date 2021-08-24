using Playlist.DAL.Interfaces.Entities;

namespace Playlist.DAL.Entities
{
    public class PlaylistItem: IEntity
    {
        public int Id { get; set; }
        public int PlaylistId { get; set; }
        public int AlbumId { get; set; }
        public int SongId { get; set; }
        public int ArtistId { get; set; }
    }
}