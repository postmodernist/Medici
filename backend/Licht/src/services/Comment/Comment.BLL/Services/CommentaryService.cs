using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Comment.BLL.Interfaces;
using Comment.DAL.Entites;
using Comment.DAL.Interfaces;
using Comment.DAL.UnitOfWork;
using LichtDataPack.Dtos.Comments;
using LichtDataPack.ViewModels.Comments;

namespace Comment.BLL.Services
{
    public class CommentaryService:ICommentaryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public CommentaryService(IMapper mapper)
        {
            _unitOfWork = new UnitOfWork();
            _mapper = mapper;
        }

        public async Task<IEnumerable<CommentaryViewModel>> GetAllComments()
        {
            var comments = _mapper.Map<IEnumerable<CommentaryViewModel>>(await _unitOfWork.CommentaryRepository.GetAllAsync());
            //Todo decorate view model
            return comments;
        }

        public async Task<CommentaryViewModel> GetCommentById(int id)
        {
            var comment = _mapper.Map<CommentaryViewModel>(await _unitOfWork.CommentaryRepository.GetByIdAsync(id));
            //Todo decorate view model
            return comment;
        }

        public async Task<CommentaryDto> AddCommentary(CommentaryDto commentary)
        {
            var result =  await _unitOfWork.CommentaryRepository.AddAsync(_mapper.Map<Commentary>(commentary));
            return _mapper.Map<CommentaryDto>(result);
        }

        public async Task<CommentaryDto> UpdateCommentary(CommentaryDto commentary)
        {
            var result = await _unitOfWork.CommentaryRepository.UpdateAsync(_mapper.Map<Commentary>(commentary));
            return _mapper.Map<CommentaryDto>(result);
        }

        public async Task DeleteCommentary(int id)
        {
            await _unitOfWork.CommentaryRepository.DeleteAsync(id);
        }
    }
}