using Posts.DAL.Entities;
using Posts.DAL.Infrastructure;
using Posts.DAL.Interfaces;

namespace Posts.DAL.Repositories
{
    public class PostRepository:GenericRepository<Post>, IPostRepository
    {
        public PostRepository(PostDbContext context) : base(context)
        {
        }
    }
}