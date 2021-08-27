using System.Collections.Generic;
using System.Threading.Tasks;
using MarxDtos.Dtos.Discount;

namespace Discount.BLL.Interfaces
{
    public interface IDiscountService
    {
        Task<IEnumerable<DiscountRecordDto>> GetAllDiscounts();
        Task<DiscountRecordDto> GetDiscountById(int id);
        Task<DiscountRecordDto> AddDiscount(DiscountRecordDto discount);
        Task<DiscountRecordDto> UpdateDiscount(DiscountRecordDto discount);
        Task DeleteDiscount(int id);
    }
}