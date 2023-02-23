using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace SSM.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Roles> roles { get; set; }
        public DbSet<User_role> user_roles { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> category { get; set; }
        public DbSet<Users> users { get; set; }

    }
}

