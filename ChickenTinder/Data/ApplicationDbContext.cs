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
                .HasKey(gc => new { gc.Chicken_Tinder_UserId, gc.GroupId });
            builder.Entity<Group_Chicken_Tinder_User>()
                .HasOne(gc => gc.Group)
                .WithMany(g => g.Group_Chicken_Tinder_Users)
                .HasForeignKey(gc => gc.GroupId);
            builder.Entity<Group_Chicken_Tinder_User>()
                .HasOne(gc => gc.Chicken_Tinder_User)
                .WithMany(c => c.Group_Chicken_Tinder_Users)
                .HasForeignKey(gc => gc.Chicken_Tinder_UserId);
            builder.Entity<Restaurant_Chicken_Tinder_User>()
                .HasKey(rc => new { rc.RestaurantId, rc.Chicken_Tinder_UserId });
            builder.Entity<Restaurant_Chicken_Tinder_User>()
                .HasOne(rc => rc.Restaurant)
                .WithMany(r => r.Restaurant_Chicken_Tinder_Users)
                .HasForeignKey(rc => rc.RestaurantId);
            builder.Entity<Restaurant_Chicken_Tinder_User>()
                .HasOne(rc => rc.Chicken_Tinder_User)
                .WithMany(c => c.Restaurant_Chicken_Tinder_Users)
                .HasForeignKey(rc => rc.Chicken_Tinder_UserId);
            builder.Entity<Group_Restaurant>()
                .HasKey(gr => new { gr.GroupId, gr.RestaurantId });
            builder.Entity<Group_Restaurant>()
                .HasOne(gr => gr.Group)
                .WithMany(g => g.Group_Restaurants)
                .HasForeignKey(gr => gr.GroupId);
            builder.Entity<Group_Restaurant>()
                .HasOne(gr => gr.Restaurant)
                .WithMany(r => r.Group_Restaurants)
                .HasForeignKey(gr => gr.RestaurantId);
        }
        public DbSet<Chicken_Tinder_User> Chicken_Tinder_Users { get; set; }
        public DbSet<Food_Type> Food_Types { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
