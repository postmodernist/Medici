using System.Collections.Generic;
using System.Threading.Tasks;
using LichtDataPack.Dtos.Posts;
using LichtDataPack.ViewModels.Posts;

namespace Posts.BLL.Interfaces
{
    public interface IPostService
    {
        Task<IEnumerable<PostViewModel>> GetPosts();
        Task<PostViewModel> GetPostById(int id);
        Task<PostDto> AddPost(PostDto post);
        Task<PostDto> UpdatePost(PostDto post);
        Task DeletePost(int id);
    }
}