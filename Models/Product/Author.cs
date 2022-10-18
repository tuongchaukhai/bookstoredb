using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bookstore.Models.Product
{
    [Table("Authors")]
    public class Author
    {
        public int Id { get; set; }

        [DisplayName("Tác giả"), Required(ErrorMessage = "Phải nhập tên tác giả")]
        [StringLength(50, ErrorMessage = "Vượt quá kí tự cho phép")]
        public string Name { get; set; }
    }
}