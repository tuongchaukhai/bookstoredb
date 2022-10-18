using System.ComponentModel.DataAnnotations.Schema;

namespace bookstore.Models.Product
{
    [Table("ProductImageProducts")]
    public class ProductImageProduct
    {
        public int ProductId{get; set;}
        public int ImageProductId{get; set;}

        [ForeignKey("ProductId")]
        public ProductModel Product { get; set; }
        [ForeignKey("ImageProductId")] 
        public ImageProduct ImageProduct { get; set; }
    }
}