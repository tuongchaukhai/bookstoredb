using System.ComponentModel.DataAnnotations;

namespace bookstore.Models.Product
{
    public class ImageProduct
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Phải nhập URL")]
        [DataType(DataType.ImageUrl)]
        public string URL { get; set; }
    }
}