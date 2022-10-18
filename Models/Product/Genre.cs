using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bookstore.Models.Product
{
    [Table("Genres")]
    public class Genre
    {
        public int Id { get; set; }
        [DisplayName("Thể loại"), Required(ErrorMessage = "Phải nhập tên thể loại")]
        [StringLength(40, ErrorMessage = "Vượt quá kí tự cho phép")]
        public string Name { get; set; }
        

    }
}