using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bookstore.Models.Product
{
    [Table("Colors")]
    public class Color
    {
        public int Id { get; set; }

        [DisplayName("Màu"), Required(ErrorMessage = "Phải nhập tên màu")]
        [StringLength(20, ErrorMessage = "Vượt quá kí tự cho phép")]
        public string Name { get; set; }
    }
}