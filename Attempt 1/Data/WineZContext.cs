using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Attempt_1.Models;

namespace Attempt_1.Data
{
    public class WineZContext : DbContext
    {
        public WineZContext (DbContextOptions<WineZContext> options)
            : base(options)
        {
        }

        public DbSet<Wine> Wines { get; set; } = default!;
        public DbSet<UserProfile> UserProfiles { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<Subscription> Subscriptions { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

			// Define the relationship between Order and UserProfile
			modelBuilder.Entity<Order>()
		       .HasOne(p => p.userprofile)
		       .WithMany()
		       .HasForeignKey(o => o.UserID)
               .OnDelete(DeleteBehavior.Restrict)
			  ;
			
            // Define the relationship between Order and Wine
			modelBuilder.Entity<Order>()
				.HasOne(o => o.wine)
				.WithMany()
				.HasForeignKey(o => o.WineID)
				.OnDelete(DeleteBehavior.Restrict);

			// Define the relationship between Order and Subscription
			modelBuilder.Entity<Order>()
				.HasOne(o => o.subscription)
				.WithMany()
				.HasForeignKey(o => o.SubID)
				.OnDelete(DeleteBehavior.Restrict);
			
			base.OnModelCreating(modelBuilder);
		}
	}
}
