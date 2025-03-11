using System;
using Microsoft.EntityFrameworkCore;
using ProductApp.Domain.Entities;

namespace ProductApp.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Product> Product { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Product>().HasData(
                new Product { Id = Guid.NewGuid(), Name = "Phone", Value = 100, Quantity = 100 },
                 new Product { Id = Guid.NewGuid(), Name = "Mouse", Value = 200, Quantity = 100 },
                  new Product { Id = Guid.NewGuid(), Name = "Keyboard", Value = 300, Quantity = 100 },
                   new Product { Id = Guid.NewGuid(), Name = "Book", Value = 400, Quantity = 100 }
                );
            base.OnModelCreating(modelBuilder);
        }

    }
}
