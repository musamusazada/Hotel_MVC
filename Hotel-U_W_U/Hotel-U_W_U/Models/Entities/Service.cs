using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_U_W_U.Models.Entities
{
    public class Service : BaseEntity
    {
        [Required]
        public string name { get; set; }

        [Required]
        public string description { get; set; }
        public string img { get; set; }
        [NotMapped]
        public IFormFile file { get; set; }
    }
}
