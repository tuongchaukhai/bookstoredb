using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bookstore.Models.Product
{
    [Table("ImageProducts")]
    public class ImageProduct
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Phải nhập URL")]
        [DataType(DataType.ImageUrl)]
        public string URL { get; set; }
    }
}