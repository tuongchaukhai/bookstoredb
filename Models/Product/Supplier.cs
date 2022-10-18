using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bookstore.Models.Product
{
    [Table("Suppliers")]
    public class Supplier
    {
        public int Id { get; set; }

        [DisplayName("Nhà cung cấp")]
        [Required(ErrorMessage = "Phải nhập tên nhà cung cấp")]
        [StringLength(120, ErrorMessage = "Vượt quá kí tự cho phép")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Phải tạo URL")]
        [RegularExpression(@"^[a-zA-Z0-9]*$", ErrorMessage = "Chỉ dùng các kí tự [a-zA-Z0-9]]")]
        public string Slug { get; set; }
    }
}