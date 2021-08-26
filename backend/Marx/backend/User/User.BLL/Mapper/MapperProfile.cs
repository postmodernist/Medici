using AutoMapper;
using MarxDtos.Dtos.User;
using User.DAL.Entities;

namespace User.BLL.Mapper
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<UserDto, UserRecord>();
            CreateMap<UserDto, UserRecord>().ReverseMap();
        }
    }
}