using System.Collections.Generic;
using Post.Domain.Interfaces;

namespace Post.Domain.Entities.Attachment
{
    public class PostAttachmentList: IEntity
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public IEnumerable<PostAttachment> Attachments { get; set; }
    }
}