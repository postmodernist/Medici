using Comment.DAL.Entites;
using Comment.DAL.Infrastructure;
using Comment.DAL.Interfaces;

namespace Comment.DAL.Repositories.EntitiesRepositories
{
    public class CommentaryReplyRepository:GenericRepository<CommentaryReply>, ICommentaryReplyRepository
    {
        public CommentaryReplyRepository(CommentaryDbContext context) : base(context)
        {
        }
    }
}