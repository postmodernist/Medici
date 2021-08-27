using Catalog.DAL.Interfaces;

namespace Catalog.DAL.Entities
{
    public class CatalogItem:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int InventoryItemId { get; set; }
        public int FileId { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}