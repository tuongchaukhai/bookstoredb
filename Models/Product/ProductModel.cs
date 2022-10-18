using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bookstore.Models.Product
{
    [Table("Products")]
    public class ProductModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Phải nhập tên sản phẩm")]
        [DisplayName("Tên sản phẩm")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Phải nhập giá sản phẩm")]
        [Range(0, Double.MaxValue, ErrorMessage = "Chỉ nhập từ {0} đến {1}")]
        public double Price { get; set; }

        [DataType(DataType.ImageUrl)]
        public string ImageURL { get; set; }

        [DisplayName("Mô tả")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [DisplayName("Số lượng")]
        [Range(0, int.MaxValue, ErrorMessage = "Chỉ nhập từ {0} đến {1}")]
        public int Quantity { get; set; }

        [DisplayName("Trọng lượng")]
        [Range(0, 100, ErrorMessage = "Chỉ nhập từ {0} đến {1}")]
        public double? Weight { get; set; }

        [DisplayName("Kích thước bao bì")]
        public string Size { get; set; }

        [DisplayName("Lượt xem")]
        public int? ViewCount { get; set; }

        [Required(ErrorMessage = "Phải tạo URL")]
        [RegularExpression(@"^[a-zA-Z0-9]*$", ErrorMessage = "Chỉ dùng các kí tự [a-zA-Z0-9]]")]
        public string Slug { get; set; }

        public bool? HotFlag { get; set; }
        public bool? HomeFlag { get; set; }

        public int SupplierId { get; set; }

        [ForeignKey("SupplierId")]
        public Supplier Supplier { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
        public List<ProductGenre> ProductGenres { get; set; }
        public List<ProductImageProduct> ProductImageProducts { get; set; }

        //Books
        [DisplayName("Loại bìa")]
        public string? BookLayout { get; set; }

        [DisplayName("Số trang"), Range(0, Int32.MaxValue, ErrorMessage = "Chỉ được nhập từ 0 đến {1}")]
        public int? PageCount { get; set; }

        [DisplayName("Năm xuất bản"), StringLength(4, ErrorMessage = "Chỉ được nhập 4 kí tự")]
        public DateTime? PublicationDate { get; set; }

        [DisplayName("Người dịch")]
        [StringLength(50, ErrorMessage = "Vượt quá kí tự cho phép")]
        public string? Translator { get; set; }

        public int? PublisherId { get; set; }
        public int? AuthorId { get; set; }

        //FK
        [ForeignKey("PublisherId")]
        public Publisher? Publisher { get; set; }
        [ForeignKey("AuthorId")]
        public Author? Author { get; set; }

        //Items
        [DisplayName("Xuất xứ")]
        public string? Origin { get; set; }

        [DisplayName("Chất liệu")]
        public string? Material { get; set; }

        [DisplayName("Thông số kỹ thuật")]
        public string? Specification { get; set; }

        [DisplayName("Hướng dẫn sử dụng")]
        public string? Direction { get; set; }

        public int? ColorId { get; set; }
        public int? AgeId { get; set; }
        public int? BrandId { get; set; }
        public int? CategoryId { get; set; }

        [ForeignKey("ColorId")]
        public Color? Color { get; set; }
        [ForeignKey("AgeId")]
        public Age? Age { get; set; }
        [ForeignKey("BrandId")]
        public Brand? Brand { get; set; }
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }
    }
}