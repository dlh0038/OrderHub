namespace OrderHub.Shared.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; } = null!;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; } = null!;
        public string Cellnumber { get; set; } = null!;
        public ICollection<Order> Orders { get; set; }
    }
}