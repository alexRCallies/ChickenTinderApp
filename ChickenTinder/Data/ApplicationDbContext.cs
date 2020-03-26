using System;
using System.Collections.Generic;
using System.Text;
using ChickenTinder.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ChickenTinder.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
                .HasData(
                new IdentityRole
                {
                    Name = "Chicken Tinder User",
                    NormalizedName = "CHICKEN TINDER USER"
                }
            );
            builder.Entity<Group_Chicken_Tinder_User>()
                .HasKey(c => new { c.Chicken_Tinder_UserId, c.GroupId });
            builder.Entity<Group_Restaurant>()
                .HasKey(c => new { c.GroupId, c.RestaurantId });
            builder.Entity<Restaurant_Chicken_Tinder_User>()
                .HasKey(c => new { c.RestaurantId, c.Chicken_Tinder_UserId });

        }
        public DbSet<Chicken_Tinder_User> Chicken_Tinder_Users { get; set; }
        public DbSet<Food_Type> Food_Types { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
