using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_U_W_U.Models.Entities
{
    public class Hotel : BaseEntity
    {
        public User user { get; set; }
        [Required]
        public string userID { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string desc { get; set; }
        [Required]
        public string img { get; set; }
        [NotMapped]
        public IFormFile file { get; set; }
        public List<Room> rooms { get; set; }
    }
}
