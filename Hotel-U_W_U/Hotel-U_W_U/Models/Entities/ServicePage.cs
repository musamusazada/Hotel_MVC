using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hotel_U_W_U.Models.Entities
{
    public class ServicePage : PageBreadcrumb
    {
        [Required, MinLength(10), MaxLength(40)]

        public string mainTitle { get; set; }
        [Required, MinLength(10), MaxLength(150)]
        public string mainText { get; set; }
        public List<Service> Services { get; set; }
    }
}
