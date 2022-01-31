using System.ComponentModel.DataAnnotations;

namespace Hotel_U_W_U.Models.ViewModel
{
    public class LoginViewModel
    {
        [Required, MaxLength(100), MinLength(5)]
        public string Username { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
