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
    public class CommentaryReplyService: ICommentaryReplyService
    {
        private readonly IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public CommentaryReplyService(IMapper mapper)
        {
            _unitOfWork = new UnitOfWork();
            _mapper = mapper;
        }
        public async Task<IEnumerable<CommentaryReplyViewModel>> GetAllReplies()
        {
            var replies =
                _mapper.Map<IEnumerable<CommentaryReplyViewModel>>(await _unitOfWork.CommentaryReplyRepository
                    .GetAllAsync());
            //Todo add filtration by comment Id
            return replies;
        }

        public async Task<CommentaryReplyViewModel> GetReplyById(int id)
        {
            var reply = _mapper.Map<CommentaryReplyViewModel>(await _unitOfWork.CommentaryReplyRepository.GetByIdAsync(id));
            return reply;
        }

        public async Task<CommentaryReplyDto> AddReply(CommentaryReplyDto commentaryReply)
        {
            var result = await _unitOfWork.CommentaryReplyRepository.AddAsync(_mapper.Map<CommentaryReply>(commentaryReply));
            return _mapper.Map<CommentaryReplyDto>(result);
        }

        public async Task<CommentaryReplyDto> UpdateReply(CommentaryReplyDto commentaryReply)
        {
            var result = await _unitOfWork.CommentaryReplyRepository.UpdateAsync(_mapper.Map<CommentaryReply>(commentaryReply)) ;
            return _mapper.Map<CommentaryReplyDto>(result);
        }

        public async Task DeleteReply(int id)
        {
            await _unitOfWork.CommentaryReplyRepository.DeleteAsync(id);
        }
    }
}