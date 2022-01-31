using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_U_W_U.Models.Entities
{
    public class Setting : BaseEntity
    {
        public string logoImg { get; set; }
        [Required]
        public string location { get; set; }

        [Required]
        [MinLength(10), MaxLength(20)]
        public string receptionPhone { get; set; }

        [Required]
        [MinLength(10), MaxLength(20)]
        public string shuffleServicePhone { get; set; }

        [Required]
        [MinLength(10), MaxLength(20)]
        public string restaurantPhone { get; set; }

        [NotMapped]
        public IFormFile logoFile { get; set; }
    }
}
