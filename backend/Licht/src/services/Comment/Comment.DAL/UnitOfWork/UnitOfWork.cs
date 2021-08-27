using Comment.DAL.Infrastructure;
using Comment.DAL.Interfaces;
using Comment.DAL.Repositories.EntitiesRepositories;

namespace Comment.DAL.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly ICommentaryRepository _commentaryRepository;
        private readonly ICommentaryReplyRepository _commentaryReplyRepository;
        private readonly ICommentaryAttachmentRepository _commentaryAttachmentRepository;
        private CommentaryDbContext _context;
        public UnitOfWork()
        {
            _context = new CommentaryDbContext();
            _commentaryAttachmentRepository = new CommentaryAttachmentRepository(_context);
            _commentaryReplyRepository = new CommentaryReplyRepository(_context);
            _commentaryRepository = new CommentaryRepository(_context);
        }

        public ICommentaryRepository CommentaryRepository
        {
            get
            {
                return _commentaryRepository;
            }

        }

        public ICommentaryAttachmentRepository CommentaryAttachmentRepository
        {
            get
            {
                return _commentaryAttachmentRepository;
            }
        }

        public ICommentaryReplyRepository CommentaryReplyRepository
        {
            get
            {
                return _commentaryReplyRepository;
            }
        }
    }
}