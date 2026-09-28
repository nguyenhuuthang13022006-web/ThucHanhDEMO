using System.ComponentModel.DataAnnotations;

namespace Example05.Models.DataModels
{
    public class Member
    {
        public string MemberId { get; set; } = string.Empty;

        [Required(ErrorMessage = "Tên đăng nhập không được trống")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Họ và tên không được trống")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Hãy nhập Password")]
        [StringLength(20, MinimumLength = 6,
            ErrorMessage = "Mật khẩu phải từ 6 đến 20 ký tự")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email không được bỏ trống")]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Số điện thoại không được trống")]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Ngày sinh không được trống")]
        public DateTime Birthday { get; set; }
    }
}