using ResourceDAL.Interfaces;

namespace ResourceDAL.Entities;

public class ResourceItem: IEntity
{
    public Guid Id { get; set; }
    public string FileName { get; set; }
    public string FileUri { get; set; }
    public string AsociatedWith { get; set; }
}