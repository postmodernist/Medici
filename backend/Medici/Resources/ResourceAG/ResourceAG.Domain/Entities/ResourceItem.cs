using ResourceAG.Domain.Interfaces;

namespace ResourceAG.Domain.Entities
{
    public class ResourceItem: IEntity
    {
        public int Id { get; set; }
        public int FileId { get; set; }
        public string Name { get; set; }
        public string FileUri { get; set; }
        public ResourceType ResourceType { get; set; }
        
    }
}