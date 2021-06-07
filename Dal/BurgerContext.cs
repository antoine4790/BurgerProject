using ClassLibrary;
using Microsoft.EntityFrameworkCore;
using System;

namespace Dal
{
    public class BurgerContext : DbContext
    {
        public DbSet<Beverage> Beverages { get; set; }
        public DbSet<Dessert> Desserts { get; set; }
        public DbSet<Burger> Burgers { get; set; }
        public DbSet<Side> Sides { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Product> Products { get; set; }

        public BurgerContext()
            : base()
        {
        }
        public BurgerContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=BurgerDatabase;Integrated Security=true");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>()
                        .HasOne(m => m.Beverage);

            modelBuilder.Entity<Menu>()
                        .HasOne(m => m.Dessert);

            modelBuilder.Entity<Menu>()
                        .HasOne(m => m.Burger);

            modelBuilder.Entity<Menu>()
                        .HasOne(m => m.Side);


            base.OnModelCreating(modelBuilder);
        }

    }
}
