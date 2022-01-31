using Hotel_U_W_U.Models.Entities;
using System.ComponentModel.DataAnnotations;
namespace Hotel_U_W_U.Models.Entities
{
    public class ContactPage : PageBreadcrumb
    {
        [Required]

        public string location { get; set; }
        [Required]
        public string phone { get; set; }
        [Required, EmailAddress, DataType(DataType.EmailAddress)]
        public string email { get; set; }
    }
}
