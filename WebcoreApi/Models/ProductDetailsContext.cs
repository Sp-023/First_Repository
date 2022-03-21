using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebcoreApi.Models
{
    public partial class ProductDetailsContext : DbContext
    {
        public ProductDetailsContext()
        {
        }

        public ProductDetailsContext(DbContextOptions<ProductDetailsContext> options)
            : base(options)
        {
        }

        public DbSet<ProductDt> ProductDt { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning 
                optionsBuilder.UseSqlServer("Server=HP-SP\\SQLEXPRESS;Database=ProductDetails;Trusted_Connection=True;");
            }
        }*/

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductDt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProductDT");

                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.ProCategory)
                    .HasColumnName("pro_category")
                    .HasMaxLength(50);

                entity.Property(e => e.ProName)
                    .HasColumnName("pro_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ProPrice).HasColumnName("pro_price");

                entity.Property(e => e.ProQuantity).HasColumnName("pro_quantity");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);*/
    }
}
