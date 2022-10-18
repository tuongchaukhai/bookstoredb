using System.ComponentModel.DataAnnotations.Schema;

namespace bookstore.Models.Product
{
    [Table("ProductGenres")]
    public class ProductGenre
    {
        public int ProductId { get; set; }
        public int GenreId { get; set; }

        [ForeignKey("ProductId")]
        public ProductModel Product { get; set; }
        [ForeignKey("GenreId")]
        public Genre Genre { get; set; }
    }
}