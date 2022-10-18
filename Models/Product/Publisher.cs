using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bookstore.Models.Product
{
    [Table("Publishers")]
    public class Publisher
    {
        public int Id { get; set; }
        
        [DisplayName("Nhà xuất bản")]
        [Required(ErrorMessage = "Phải nhập tên nhà xuất bản")]
        [StringLength(100, ErrorMessage = "Vượt quá kí tự cho phép")]
        public string Name { get; set; }
    }
}