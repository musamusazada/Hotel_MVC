using Microsoft.AspNetCore.Identity;

namespace Hotel_U_W_U.Models.Entities
{
    public class User : IdentityUser
    {
        public bool hasHotel { get; set; } = false;
    }
}
