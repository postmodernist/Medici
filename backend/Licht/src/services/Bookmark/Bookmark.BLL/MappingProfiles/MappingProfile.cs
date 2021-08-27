using AutoMapper;
using Bookmark.DAL.Entity;
using LichtDataPack.Dtos.Bookmark;
using LichtDataPack.ViewModels;
using LichtDataPack.ViewModels.Bookmark;

namespace Bookmark.BLL.MappingProfiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<BookmarkRecord, BookmarkDto>();
            CreateMap<BookmarkRecord, BookmarkDto>().ReverseMap();
            CreateMap<BookmarkViewModel, BookmarkRecord>();
            CreateMap<BookmarkViewModel, BookmarkRecord>().ReverseMap();
        }
    }
}