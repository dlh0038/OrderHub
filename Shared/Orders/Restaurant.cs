namespace OrderHub.Shared.Models
{
    public class Restaurant
    {
        public int ID { get; set; }
        public string RestaurantName { get; set; } = string.Empty;
        public string Address { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public ICollection<Order> Orders {get; set; }
    }
}