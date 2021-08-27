using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Threading.Tasks;
using AutoMapper;
using Discount.BLL.Interfaces;
using Discount.DAL.Entities;
using Discount.DAL.Repositories;
using MarxDtos.Dtos.Discount;

namespace Discount.BLL.Services
{
    public class DiscountService: IDiscountService
    {
        private readonly IMapper _mapper;
        private readonly DiscountRecordRepository _repository;

        public DiscountService(IMapper mapper)
        {
            _mapper = mapper;
            _repository = new DiscountRecordRepository();
        }

        public async Task<IEnumerable<DiscountRecordDto>> GetAllDiscounts()
        {
            return _mapper.Map<IEnumerable<DiscountRecordDto>>(await _repository.GetAllAsync());
        }

        public async Task<DiscountRecordDto> GetDiscountById(int id)
        {
            return _mapper.Map<DiscountRecordDto>(await _repository.GetByIdAsync(id));
        }

        public async Task<DiscountRecordDto> AddDiscount(DiscountRecordDto discount)
        {
            var result = await _repository.AddAsync(_mapper.Map<DiscountRecord>(discount));
            return _mapper.Map<DiscountRecordDto>(result);
        }

        public async Task<DiscountRecordDto> UpdateDiscount(DiscountRecordDto discount)
        {
            var result = await _repository.UpdateAsync(_mapper.Map<DiscountRecord>(discount));
            return _mapper.Map<DiscountRecordDto>(result);
        }

        public async Task DeleteDiscount(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}