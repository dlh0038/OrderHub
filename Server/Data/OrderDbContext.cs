using OrderHub.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace OrderHub.Server.Data
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext()
        {

        }
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        {

        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<User> Users { get; set; }
    }
}