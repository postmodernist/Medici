namespace MarxDtos.Dtos.Discount
{
    public class DiscountRecordDto
    {
        public int Id { get; set; }
        public int CatalogItemId { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
    }
}