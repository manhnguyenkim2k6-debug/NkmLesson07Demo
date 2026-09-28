using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NkmLesson07Demo.Models
{
    public class NkmMember
    {
        public int Id { get; set; }
        [DisplayName("Tai khoan ")]
        [Required(ErrorMessage ="Tai khoan khong duoc de trong")]
        [StringLength(20,MinimumLength =3,ErrorMessage ="Tai khoan co do dai trong khoang 3-20 ky tu")]
        public string UserName { get; set; }
        [DisplayName("Mat Khau")]
        [StringLength(100,MinimumLength = 8, ErrorMessage="Mat khau toi thieu 8 ky tu")]
        public string Password { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Email khong duoc de trong")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DisplayName("Dien thoai")]
        [Required(ErrorMessage = "Ban chua nhap dien thoai")]
        [RegularExpression(@"^0\d{9,9}",ErrorMessage ="Dien thoai phai la 10 ky tu so, bat dau bang so 0" )]
        public string Phone {  get; set; }
        

        public DateTime Birthday { get; set; }
    }
}
