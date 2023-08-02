using Microsoft.EntityFrameworkCore;
using System.Data;
using Online_Store.Domain.Entities;
using Microsoft.AspNetCore.SignalR;

namespace Online_Store.Domain
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<Discounts> Discounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<CartItems> CartItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var role = new Role
			{
				Name = "admin",
			};

            var user = new User
            {
                Name = "Max",
                Email = "Admin",
                Password = SecurePasswordHasher.Hash("aspoqw12"),
                ApiKey = "xd",
                PhoneNumber = "1234567890",
            };

			modelBuilder.Entity<Role>().HasData(role);

			modelBuilder.Entity<Role>().HasData(new Role
			{
				Name = "user",
			});
			modelBuilder.Entity<User>().HasData(user);

            modelBuilder.Entity<UserRole>().HasData(new UserRole
            {
                RoleId = role.Id,
                UserId = user.Id
            });
        }

    }
}
