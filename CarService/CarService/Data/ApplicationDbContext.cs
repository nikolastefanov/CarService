using CarService.Data.Models;
using Microsoft.AspNetCore.Identity;
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

        public DbSet<Work> Works { get; set; }

        public DbSet<IssueType> IssueTypes { get; set; }

        public DbSet<Mechanic> Mechanics { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Issue>()
               .HasOne(i => i.Car)
               .WithMany(c => c.Issues)
               .HasForeignKey(i => i.CarId)
               .OnDelete(DeleteBehavior.Restrict);
          
          
            builder.Entity<Issue>()
             .HasOne(i => i.IssueType)
             .WithMany(it => it.Issues)
             .HasForeignKey(i => i.IssueTypeId)
             .OnDelete(DeleteBehavior.Restrict);
          
            builder.Entity<Work>()
               .HasOne(w=>w.Order)
               .WithMany(o=>o.Works)
               .HasForeignKey(w=>w.OrderId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
               .Entity<Mechanic>()
               .HasOne<IdentityUser>()
               .WithOne()
               .HasForeignKey<Mechanic>(d => d.UserId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Work>()
                .HasOne(w => w.Mechanic)
                .WithMany(m => m.Works)
                .HasForeignKey(w => w.MechanicId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<SparePart>()
               .HasOne(sp=>sp.Order)
              .WithMany(o=>o.SpareParts)
              .HasForeignKey(sp=>sp.OrderId)
               .OnDelete(DeleteBehavior.Restrict);
          
            builder.Entity<Order>()
               .HasOne(o=>o.Car)
               .WithMany(c=>c.Orders)
               .HasForeignKey(o=>o.CarId)     
               .OnDelete(DeleteBehavior.Restrict);
          
            builder.Entity<SparePart>()
             .HasOne(sp => sp.IssueType)
             .WithMany(it=>it.SpareParts)
             .HasForeignKey(sp => sp.IssueTypeId)
             .OnDelete(DeleteBehavior.Restrict);

            builder
               .Entity<Mechanic>()
               .HasOne<IdentityUser>()
               .WithOne()
               .HasForeignKey<Mechanic>(d => d.UserId)
               .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}
