using AutoMapper;
using ImageAlbum.Domain.Entites;
using LichtDataPack.Dtos.ImageAlbum;

namespace ImageAlbum.Application.MappingProfile
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<ImageAlbumDto, ImageAlbumRecord>();
            CreateMap<ImageAlbumDto, ImageAlbumRecord>().ReverseMap();
        }
    }
}