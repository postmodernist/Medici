using Comment.DAL.Entites;
using Comment.DAL.Infrastructure;
using Comment.DAL.Interfaces;

namespace Comment.DAL.Repositories.EntitiesRepositories
{
    public class CommentaryRepository:GenericRepository<Commentary>, ICommentaryRepository
    {
        //private readonly CommentaryDbContext _context;
        public CommentaryRepository(CommentaryDbContext context) : base(context)
        {
            //_context = context;
        }
    }
}