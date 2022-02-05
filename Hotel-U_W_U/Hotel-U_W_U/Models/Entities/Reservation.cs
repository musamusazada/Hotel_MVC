using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_U_W_U.Models.Entities
{
    public class Reservation : BaseEntity
    {
        public int roomID { get; set; }
        [ForeignKey("roomID")]
        public Room room { get; set; }
        [Required]
        public DateTime checkIn { get; set; }
        [Required]

        public DateTime checkOut { get; set; }
        public int total { get; set; }

    }
}
