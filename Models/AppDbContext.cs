using Microsoft.EntityFrameworkCore;
using bookstore.Models.Product;

namespace bookstore.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // // Bỏ tiền tố AspNet của các bảng: mặc định
            // foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            // {
            //     var tableName = entityType.GetTableName();
            //     if (tableName.StartsWith("AspNet"))
            //     {
            //         entityType.SetTableName(tableName.Substring(6));
            //     }
            // }

            modelBuilder.Entity<ProductModel>(entity =>
            {
                entity.HasIndex(c => c.Slug).IsUnique();
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasIndex(c => c.Slug).IsUnique();
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasIndex(c => c.Slug).IsUnique();
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.HasKey(c => new { c.ProductId, c.CategoryId });
            });

            modelBuilder.Entity<ProductGenre>(entity =>
            {
                entity.HasKey(c => new { c.ProductId, c.GenreId });
            });

            modelBuilder.Entity<ProductImageProduct>(entity =>
            {
                entity.HasKey(c => new { c.ProductId, c.ImageProductId });
            });

        }


        public DbSet<ProductModel> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Age> Ages { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ImageProduct> ImageProducts { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductGenre> ProductGenres { get; set; }
        public DbSet<ProductImageProduct> ProductImageProducts { get; set; }

    }
}

