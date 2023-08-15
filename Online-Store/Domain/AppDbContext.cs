using Microsoft.EntityFrameworkCore;
using System.Data;
using Online_Store.Domain.Entities;
using Online_Store.Domain.Entities.Products;
using Microsoft.AspNetCore.SignalR;

namespace Online_Store.Domain
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<Discounts> Discounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<CartItems> CartItems { get; set; }
        public DbSet<ProductImages> ProductImages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasDiscriminator<string>("Product")
                .HasValue<Entities.Products.Monitor>("Monitor")                     
                .HasValue<Keyboard>("Keyboard");

            base.OnModelCreating(modelBuilder);

            var role = new Role
            {
                Name = "admin",
                Priority = 1
            };

            modelBuilder.Entity<Role>().HasData(role); modelBuilder.Entity<Role>().HasData(new Role
            {
                Name = "manager",
                Priority = 2
            });

            modelBuilder.Entity<Role>().HasData(new Role
            {
                Name = "supporter",
                Priority = 3
            });

            modelBuilder.Entity<Role>().HasData(new Role
            {
                Name = "user",
                Priority = 4
            });
        }

    }
}