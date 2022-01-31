using Microsoft.AspNetCore.Mvc;

namespace Hotel_U_W_U.Controllers
{
    public class HotelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
