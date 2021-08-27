using AutoMapper;
using LichtDataPack.Dtos.Posts;
using LichtDataPack.ViewModels.Posts;
using Posts.DAL.Entities;

namespace Posts.BLL.MappingProfile
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Post, PostDto>();
            CreateMap<Post, PostDto>().ReverseMap();
            CreateMap<Post, PostViewModel>();
            CreateMap<Post, PostViewModel>().ReverseMap();
        }
    }
}