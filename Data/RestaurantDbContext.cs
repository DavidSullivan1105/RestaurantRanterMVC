using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RestaurantRanterMVC.Data
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options) {}
        public DbSet<RestaurantEntity> Restaurants { get; set; }
        public DbSet<RatingEntity> Ratings { get; set; }
    }
}