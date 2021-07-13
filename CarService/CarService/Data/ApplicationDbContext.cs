using CarService.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Issue> Issues { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<SparePart> SpareParts { get; set; }


       //TODO: User entity??????
          public DbSet<User> Users { get; set; }

        public DbSet<Work> Works { get; set; }

        public DbSet<IssueType> IssueTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Issue>()
             .HasOne(i => i.IssueType)
             .WithMany(i => i.Issues)
             .HasForeignKey(i => i.IssueTypeId)
             .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<Work>()
                .HasOne(w=>w.Issue)
                .WithMany(w=>w.Works)
                .HasForeignKey(w=>w.IssueId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Work>()
               .HasOne(w=>w.Order)
               .WithMany(w=>w.Works)
               .HasForeignKey(w=>w.OrderId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Issue>()
               .HasOne(i=>i.Car)
               .WithMany(i=>i.Issues)
               .HasForeignKey(i=>i.CarId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Issue>()
               .HasOne(i => i.Car)
               .WithMany(i => i.Issues)
               .HasForeignKey(i => i.CarId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<SparePart>()
               .HasOne(sp=>sp.Order)
              .WithMany(sp=>sp.SpareParts)
              .HasForeignKey(sp=>sp.OrderId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Order>()
               .HasOne(o=>o.Car)
               .WithMany(c=>c.Orders)
               .HasForeignKey(c=>c.CarId)     
               .OnDelete(DeleteBehavior.Restrict);


            base.OnModelCreating(builder);
        }
    }
}
