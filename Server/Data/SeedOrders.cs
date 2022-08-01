using OrderHub.Shared.Models;
//using OrderHub.Server.Models;
using System;
using System.Linq;

namespace OrderHub.Server.Data
{
    public static class DbInitializer
    {
        public static void Initialize(OrderDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Orders.Any())
            {
                return;   // DB has been seeded
            }
            
            //seed restaurants
            var restaurants = new Restaurant[]
            {
                new Restaurant {ID=1, RestaurantName="McDonalds", Address="123 Main Street", PhoneNumber="867-5309"}
            };
            foreach (Restaurant restaurant in restaurants)
            {
                context.Restaurants.Add(restaurant);
            }
            context.SaveChanges();
            //seed users
            var users = new User[]
            {
                new User {ID=1, Username="Doe21", LastName="Doe", FirstName="John", Email="doej@mail.com", Address="100 Main Street", Cellnumber="555-5555"}
            };
            foreach (User user in users)
            {
                context.Users.Add(user);
            }
            context.SaveChanges();
            //seed orders
            var orders = new Order[]
            {
                new Order {Id = 1, Description="Good, cheap food", Price=9.23, Rating=5, UserID=1, RestaurantID=1 }
            };
            foreach (Order order in orders)
            {
                context.Orders.Add(order);
            }
            context.SaveChanges();
        }
    }
}