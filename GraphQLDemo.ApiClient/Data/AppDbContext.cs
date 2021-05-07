using GraphQLDemo.ApiClient.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLDemo.ApiClient.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Platform> Platforms { get; set; }
    }
}