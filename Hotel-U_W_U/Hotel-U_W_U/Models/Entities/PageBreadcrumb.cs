using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_U_W_U.Models.Entities
{
    public class PageBreadcrumb
    {
        public int id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; }
        public DateTime DeletedDate { get; set; }
        public bool isDeleted { get; set; } = false;

        [Required, MinLength(4), MaxLength(30)]
        public string pageTitle { get; set; }
        [Required, MinLength(5), MaxLength(160)]

        public string pageIntro { get; set; }
        public string pageImg { get; set; }
        [NotMapped]
        public IFormFile pageFile { get; set; }
    }
}
