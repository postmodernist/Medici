using Comment.DAL.Entites;
using Comment.DAL.Infrastructure;
using Comment.DAL.Interfaces;

namespace Comment.DAL.Repositories.EntitiesRepositories
{
    public class CommentaryAttachmentRepository:GenericRepository<CommentaryAttachment>, ICommentaryAttachmentRepository
    {
        public CommentaryAttachmentRepository(CommentaryDbContext context) : base(context)
        {
        }
    }
}