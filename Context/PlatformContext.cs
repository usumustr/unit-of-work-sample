
using Microsoft.EntityFrameworkCore;
using System;

namespace UnitOfWorkSample.Context
{
    public class PlatformContext: DbContext
    {
        public PlatformContext(DbContextOptions options):base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>()
                 .HasIndex(p => p.ProductCode)
                 .IsUnique();

            builder.Entity<Product>()
                .Property(p => p.ProductCode)
                .HasMaxLength(20);

        }

        public override int SaveChanges()
        {
            var now = DateTime.Now;

            foreach(var changedEntity in ChangeTracker.Entries())
            {
                if(changedEntity.Entity is BaseEntity entity)
                {
                    switch (changedEntity.State)
                    {
                        case EntityState.Added:
                            entity.CreatedDate = now;
                            entity.UpdatedDate = now;
                            break;
                        case EntityState.Modified:
                            entity.UpdatedDate = now;
                            break;
                        default:
                            break;

                    }
                }
            }

            return base.SaveChanges();
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
