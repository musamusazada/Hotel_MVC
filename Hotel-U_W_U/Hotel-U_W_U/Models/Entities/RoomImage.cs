using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_U_W_U.Models.Entities
{
    public class RoomImage : BaseEntity
    {
        [Required]

        public int roomID { get; set; }

        [ForeignKey("hotelID")]
        public Room room { get; set; }

        [Required]

        public string img { get; set; }
        [NotMapped]
        public IFormFile file { get; set; }
    }
}
