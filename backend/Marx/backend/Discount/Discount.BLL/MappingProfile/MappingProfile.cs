using AutoMapper;
using Discount.DAL.Entities;
using MarxDtos.Dtos.Discount;

namespace Discount.BLL.MappingProfile
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<DiscountRecord, DiscountRecordDto>();
            CreateMap<DiscountRecord, DiscountRecordDto>().ReverseMap();
        }
    }
}