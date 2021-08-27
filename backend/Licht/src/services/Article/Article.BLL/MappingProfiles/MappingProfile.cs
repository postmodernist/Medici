using Article.DAL.Entities;
using AutoMapper;
using LichtDataPack.Dtos.Article;

namespace Article.BLL.MappingProfiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<ArticleRecord, ArticleDto>();
            CreateMap<ArticleRecord, ArticleDto>().ReverseMap();
        }
    }
}