using LichtDataPack.Interfaces.Entity;

namespace FileStorage.DAL.Entities
{
    public class FileRecord: IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Path { get; set; }

    }
}