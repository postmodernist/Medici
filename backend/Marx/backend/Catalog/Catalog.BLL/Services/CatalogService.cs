using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Catalog.BLL.Interfaces;
using Catalog.DAL.Entities;
using Catalog.DAL.Interfaces;
using Catalog.DAL.Repository;
using MarxDtos.Dtos.Catalog;

namespace Catalog.BLL.Services
{
    public class CatalogService: ICatalogService
    {
        private readonly IMapper _mapper;
        private readonly ICatalogItemRepository _repository;
        public CatalogService(IMapper mapper)
        {
            _mapper = mapper;
            _repository = new CatalogItemRepository();
        }
        public async Task<IEnumerable<CatalogItemDto>> GetAllItems()
        {
            return _mapper.Map<IEnumerable<CatalogItemDto>>(await _repository.GetAllAsync());
        }

        public async Task<CatalogItemDto> GetItembyId(int id)
        {
            return _mapper.Map<CatalogItemDto>(await _repository.GetByIdAsync(id));
        }

        public async Task<CatalogItemDto> AddItem(CatalogItemDto item)
        {
            var result = await _repository.AddAsync(_mapper.Map<CatalogItem>(item));
            return _mapper.Map<CatalogItemDto>(result);
        }

        public async Task<CatalogItemDto> UpdateItem(CatalogItemDto item)
        {
            var result = await _repository.UpdateAsync(_mapper.Map<CatalogItem>(item));
            return _mapper.Map<CatalogItemDto>(result);
        }

        public async Task DeleteItem(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}