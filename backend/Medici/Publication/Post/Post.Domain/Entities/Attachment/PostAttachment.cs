using Post.Domain.Interfaces;

namespace Post.Domain.Entities.Attachment
{
    public class PostAttachment: IEntity
    {
        public int Id { get; set; }
        public int ResourceId { get; set; }
        public AttachmentType AttachmentType { get; set; }
    }
}