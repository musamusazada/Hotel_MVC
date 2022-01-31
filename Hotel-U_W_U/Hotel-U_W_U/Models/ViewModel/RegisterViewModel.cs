using System.ComponentModel.DataAnnotations;

namespace Hotel_U_W_U.Models.ViewModel
{
    public class RegisterViewModel
    {
        [Required, MaxLength(100), MinLength(5)]
        public string Username { get; set; }
        [Required, EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
