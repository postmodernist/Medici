using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using LichtDataPack.Dtos.Posts;
using LichtDataPack.ViewModels.Posts;
using Posts.BLL.Interfaces;
using Posts.DAL.Entities;
using Posts.DAL.Interfaces;
using Posts.DAL.UnitOfWork;

namespace Posts.BLL.Services
{
    public class PostService:IPostService
    {
        private IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public PostService(IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = new UnitOfWork();
        }
        public async Task<IEnumerable<PostViewModel>> GetPosts()
        {
            var result = _mapper.Map<IEnumerable<PostViewModel>>(await _unitOfWork.PostRepository.GetAllAsync());
            //todo modify result
            foreach (var post in result)
            {
              // todo modify   
            }
            return result;
        }

        public async Task<PostViewModel> GetPostById(int id)
        {
            var result = _mapper.Map<PostViewModel>(await _unitOfWork.PostRepository.GetByIdAsync(id));
            // todo modify   
            return result;
        }

        public async Task<PostDto> AddPost(PostDto post)
        {
            var result = await _unitOfWork.PostRepository.AddAsync(_mapper.Map<Post>(post));
            return _mapper.Map<PostDto>(result);
        }

        public async Task<PostDto> UpdatePost(PostDto post)
        {
            var result = await _unitOfWork.PostRepository.UpdateAsync(_mapper.Map<Post>(post));
            return _mapper.Map<PostDto>(result);
        }

        public async Task DeletePost(int id)
        {
            var post = await _unitOfWork.PostRepository.GetByIdAsync(id);
            if (post.HasAttachments)
            {
                await _unitOfWork.PostAttachmentRepository.DeleteAttachmentsByPostId(id);
                await _unitOfWork.PostRepository.DeleteAsync(id);
            }
            else
            {
                await _unitOfWork.PostRepository.DeleteAsync(id);
            }
        }
    }
}