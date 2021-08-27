using AutoMapper;
using Comment.DAL.Entites;
using LichtDataPack.Dtos.Comments;
using LichtDataPack.ViewModels.Comments;

namespace Comment.BLL.MappingProfiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<CommentaryDto, Commentary>();
            CreateMap<CommentaryDto, Commentary>().ReverseMap();
            CreateMap<CommentaryReply, CommentaryReplyDto>();
            CreateMap<CommentaryReply, CommentaryReplyDto>().ReverseMap();
            CreateMap<CommentaryAttachment, CommentaryAttachmentDto>();
            CreateMap<CommentaryAttachment, CommentaryAttachmentDto>().ReverseMap();

            CreateMap<Commentary, CommentaryViewModel>();
            CreateMap<Commentary, CommentaryViewModel>().ReverseMap();
            CreateMap<CommentaryReply, CommentaryReplyViewModel>();
            CreateMap<CommentaryReply, CommentaryReplyViewModel>().ReverseMap();
        } 
    }
}