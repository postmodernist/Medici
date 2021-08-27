using System.Threading.Tasks;
using Posts.DAL.Entities;

namespace Posts.DAL.Interfaces
{
    public interface IPostAttachmentRepository:IGenericRepository<PostAttachment>
    {
        Task DeleteAttachmentsByPostId(int postId);
    }
}