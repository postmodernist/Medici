namespace MarxDtos.Dtos.Catalog
{
    public class CatalogItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int InventoryItemId { get; set; }
        public int FileId { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}