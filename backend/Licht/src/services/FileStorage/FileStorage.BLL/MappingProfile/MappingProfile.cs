using AutoMapper;
using FileStorage.DAL.Entities;
using LichtDataPack.Dtos.FileRecord;

namespace FileStorage.BLL.MappingProfile
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<FileRecord, FileRecordDto>();
            CreateMap<FileRecord, FileRecordDto>().ReverseMap();
        }
    }
}