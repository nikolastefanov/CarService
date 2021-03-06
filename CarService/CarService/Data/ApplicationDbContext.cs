
namespace CarService.Data
{
    using CarService.Data.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Issue> Issues { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Works> Works { get; set; }

        public DbSet<IssueType> IssueTypes { get; set; }

        public DbSet<Mechanic> Mechanics { get; set; }

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Issue>()
               .HasOne(i => i.Car)
               .WithMany(c => c.Issues)
               .HasForeignKey(i => i.CarId)
               .OnDelete(DeleteBehavior.Restrict); 
          
            builder.Entity<Works>()
               .HasOne(w=>w.Order)
               .WithMany(o=>o.Works)
               .HasForeignKey(w=>w.OrderId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Works>()
               .HasOne(w => w.Issue)
               .WithMany(o => o.Works)
               .HasForeignKey(w => w.IssueId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Car>()
               .HasOne(w => w.IssueType)
               .WithMany(o => o.Cars)
               .HasForeignKey(w => w.IssueTypeId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
               .Entity<Mechanic>()
               .HasOne<User>()
               .WithOne()
               .HasForeignKey<Mechanic>(d => d.UserId)
               .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}
