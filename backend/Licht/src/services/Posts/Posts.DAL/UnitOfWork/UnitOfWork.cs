using Posts.DAL.Infrastructure;
using Posts.DAL.Interfaces;
using Posts.DAL.Repositories;

namespace Posts.DAL.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly PostDbContext _context;
        private readonly IPostRepository _postRepository;
        private readonly IPostAttachmentRepository _postAttachmentRepository;

        public UnitOfWork()
        {
            _context = new PostDbContext();
            _postRepository = new PostRepository(_context);
            _postAttachmentRepository = new PostAttachmentRepository(_context);
        }

        public IPostRepository PostRepository
        {
            get
            {
                return _postRepository;
            }
        }

        public IPostAttachmentRepository PostAttachmentRepository
        {
            get
            {
                return _postAttachmentRepository;
            }
        }
    }
}