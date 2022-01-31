using System.ComponentModel.DataAnnotations;

namespace Hotel_U_W_U.Models.Entities
{
    public class Comment : BaseEntity
    {
        public Room room { get; set; }
        [Required]
        public int roomID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }

        [Required]
        public string commentText { get; set; }
    }
}
