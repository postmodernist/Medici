namespace Comment.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        public ICommentaryRepository CommentaryRepository { get; }
        public ICommentaryAttachmentRepository CommentaryAttachmentRepository { get; }

        public ICommentaryReplyRepository CommentaryReplyRepository { get; }
    }
}