using AutoMapper;
using Catalog.DAL.Entities;
using MarxDtos.Dtos.Catalog;

namespace Catalog.BLL.MappingProfile
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<CatalogItemDto, CatalogItem>();
            CreateMap<CatalogItemDto, CatalogItem>().ReverseMap();
        }
    }
}