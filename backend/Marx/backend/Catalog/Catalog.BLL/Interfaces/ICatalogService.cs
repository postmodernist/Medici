using System.Collections.Generic;
using System.Threading.Tasks;
using MarxDtos.Dtos.Catalog;

namespace Catalog.BLL.Interfaces
{
    public interface ICatalogService
    {
        public Task<IEnumerable<CatalogItemDto>> GetAllItems();
        public Task<CatalogItemDto> GetItembyId(int id);
        public Task<CatalogItemDto> AddItem(CatalogItemDto item);
        public Task<CatalogItemDto> UpdateItem(CatalogItemDto item);
        public Task DeleteItem(int id);
    }
}