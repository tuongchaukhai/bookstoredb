using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bookstore.Models.Product
{
    [Table("Brands")]
    public class Brand
    {
        public int Id { get; set; }
        [DisplayName("Thương hiệu"), Required(ErrorMessage = "Phải nhập tên thương hiệu")]
        [StringLength(100, ErrorMessage = "Vượt quá kí tự cho phép")]
        public string Name { get; set; }
    }
}