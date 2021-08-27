using System.Collections.Generic;
using System.Threading.Tasks;
using LichtDataPack.Dtos.Comments;
using LichtDataPack.ViewModels.Comments;

namespace Comment.BLL.Interfaces
{
    public interface ICommentaryReplyService
    {

        Task<IEnumerable<CommentaryReplyViewModel>> GetAllReplies();
        Task<CommentaryReplyViewModel> GetReplyById(int id);
        Task<CommentaryReplyDto> AddReply(CommentaryReplyDto commentaryReply);
        Task<CommentaryReplyDto> UpdateReply(CommentaryReplyDto commentaryReply);
        Task DeleteReply(int id);
    }
}