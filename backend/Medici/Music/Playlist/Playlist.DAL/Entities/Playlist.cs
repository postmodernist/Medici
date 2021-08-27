using System.Collections.Generic;
using Playlist.DAL.Interfaces.Entities;

namespace Playlist.DAL.Entities
{
    public class Playlist: IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CoverImageAlbumId { get; set; }
        public int CoverImageId { get; set; }
        public string CoverImageUri { get; set; }
        public string Name { get; set; }
        public IEnumerable<PlaylistItem> PlaylistItems { get; set; }
    }
}