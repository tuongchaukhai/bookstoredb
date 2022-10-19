using Microsoft.EntityFrameworkCore;
using bookstore.Models.Product;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace bookstore.Models
{
    public class AppDbContext : IdentityDbContext<AppUser>
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

            // Bỏ tiền tố "AspNet" trong tên các bảng
            foreach (var entityType in modelBuilder.Model.GetEntityTypes()) //duyệt qua từng bảng
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6)); //bỏ đi 6 kí tự đầu tiên
                }
            }

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

