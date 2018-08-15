namespace EShop.Domain.ProductAggregate
{
    public class ProductRecordModel
    {
        public string Id { get; set; }
        public string Q1 { get; set; }
        public int Size { get; set; }
        public string Color { get; set; }
        public string ItemId { get; set; }
        public double Price { get; set; }
        public double DiscountPrice { get; set; }
        public string ColorBrand { get; set; }
        public string Description { get; set; }
        public string DeliveryTime { get; set; }
    }
}
