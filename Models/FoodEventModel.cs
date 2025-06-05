namespace FoodAssembly.Models
{
    public class FoodEvent
    {
        public string EventTitle { get; set; } = "";

        public string EventDescription { get; set; } = "";

        public DateTime EndAt { get; set; } = new();

        public string IconUrl { get; set; } = "";

        public IEnumerable<EventItems> Items { get; set; } = Enumerable.Empty<EventItems>();
    }

    public class EventItems 
    {
        public string FoodName { get; set; } = "";
        public decimal DeliveryPrice { get; set; }
        public string VendorName { get; set; } = "";
        public decimal Price { get; set; } = decimal.Zero;
        public decimal PriceWithDiscount { get; set; } = decimal.Zero;
        public int Remaining { get; set; } = 0;
        public int DiscountPercent { get; set; } = 0;
        public string ImageUrl { get; set; } = "";
    }

}
