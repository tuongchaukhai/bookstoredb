using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace bookstore.Models
{
    public class AppUser : IdentityUser
    {
        [Required(ErrorMessage = "Vui lòng nhập Họ Tên")]
        [DataType(DataType.Text)]
        [DisplayName("Họ Tên")]
        public string FullName { get; set; }

        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        [DataType(DataType.PhoneNumber)]
        [DisplayName("Số điện thoại")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập địa chỉ")]
        [DisplayName("Địa chỉ")]
        [StringLength(400)]
        public string Address { get; set; }
    }
}