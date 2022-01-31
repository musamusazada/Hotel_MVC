using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_U_W_U.Models.Entities
{
    public class Room : BaseEntity
    {
        public Hotel hotel { get; set; }
        public int hotelID { get; set; }
        [Required]
        public string roomType { get; set; }
        [Required]
        public int adultCount { get; set; }
        [Required]
        public int kidCount { get; set; }
        [Required]
        public string mainImg { get; set; }
        [Required]
        public int roomSqr { get; set; }

        [NotMapped]
        public IFormFile mainFile { get; set; }

        [Required]
        public int pricePerNight { get; set; }
        [Required]
        public string roomTitle { get; set; }

        [Required]
        public string roomDesc { get; set; }
        public List<RoomImage> sideImages { get; set; }
        [NotMapped]

        public IFormFile[] sideFiles { get; set; }

        public List<Comment> comments { get; set; }

    }
}
