using AutoMapper;
using MarxDtos.Order;
using Order.DAL.Entities;
//using MarxDtos.Order;
namespace Order.BLL.Mapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<OrderRecord, OrderDto>();
            CreateMap<OrderRecord, OrderDto>().ReverseMap();
        }
    }
}