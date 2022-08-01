namespace OrderHub.Shared.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Rating { get; set; }
        public int UserID { get; set; }
        public int RestaurantID {get; set;}
        public User User {get; set;}
        public Restaurant Restaurant { get; set; }
    }
}