using System.IO;
using FileStorage.Domain.Interfaces;

namespace FileStorage.Domain.Entities
{
    public class FileRecord: IEntity
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public string GeneratedUri { get; set; }
        
    }
}