using Hotel_U_W_U.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_U_W_U.Controllers.Main_Pages
{
    public class ServiceController : Controller
    {
        private readonly AppDbContext _context;

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _context.ServicePages.Include("Services").FirstOrDefaultAsync();
            return View(model);
        }
    }
}
