namespace Posts.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        public IPostRepository PostRepository { get; }
        public IPostAttachmentRepository PostAttachmentRepository { get; }
    }
}