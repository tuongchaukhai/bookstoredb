using System.ComponentModel.DataAnnotations.Schema;

namespace bookstore.Models.Product
{
    [Table("ProductCategories")]
    public class ProductCategory
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey("ProductId")]
        public ProductModel Product { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}