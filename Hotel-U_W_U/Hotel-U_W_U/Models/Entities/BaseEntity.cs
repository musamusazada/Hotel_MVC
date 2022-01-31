using System;

namespace Hotel_U_W_U.Models.Entities
{
    public class BaseEntity
    {
        public int id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; }
        public DateTime DeletedDate { get; set; }
        public bool isDeleted { get; set; } = false;

    }
}
