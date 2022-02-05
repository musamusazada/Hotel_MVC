using Hotel_U_W_U.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Hotel_U_W_U.Controllers
{
    public class HotelController : Controller
    {
        private readonly AppDbContext _context;
        public HotelController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var hotels = await _context.hotels.ToListAsync();
            return View(hotels);
        }
    }
}
