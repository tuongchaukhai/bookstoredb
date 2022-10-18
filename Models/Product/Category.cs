using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bookstore.Models.Product
{
    [Table("Categories")]
    public class Category
    {
        public int Id { get; set; }

        [DisplayName("Danh mục"), Required(ErrorMessage = "Phải nhập tên danh mục")]
        [StringLength(100, ErrorMessage = "Vượt quá kí tự cho phép")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Phải tạo URL")]
        [RegularExpression(@"^[a-zA-Z0-9]*$", ErrorMessage = "Chỉ dùng các kí tự [a-zA-Z0-9]]")]
        public string Slug { get; set; }

        [DisplayName("Mô tả")]
        [DataType(DataType.Text)]
        public string? Description { get; set; }

        public int? ParentCategoryId { get; set; }

        [ForeignKey("ParentCategoryId")]
        public Category ParentCategory { get; set; }
    }
}