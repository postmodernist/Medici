using System.Collections.Generic;
using System.Threading.Tasks;
using LichtDataPack.Dtos.Comments;
using LichtDataPack.ViewModels.Comments;

namespace Comment.BLL.Interfaces
{
    public interface ICommentaryService
    {
        Task<IEnumerable<CommentaryViewModel>> GetAllComments();
        Task<CommentaryViewModel> GetCommentById(int id);
        Task<CommentaryDto> AddCommentary(CommentaryDto commentary);
        Task<CommentaryDto> UpdateCommentary(CommentaryDto commentary);
        Task DeleteCommentary(int id);
    }
}