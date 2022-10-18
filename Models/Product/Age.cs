using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bookstore.Models.Product
{
    [Table("Ages")]
    public class Age
    {
        public int Id { get; set; }

        [DisplayName("Độ tuổi"), Required(ErrorMessage = "Phải nhập độ tuổi")]
        [StringLength(5, ErrorMessage = "Chỉ nhập dưới {0} kí tự")]
        public string Name { get; set; }
    }
}