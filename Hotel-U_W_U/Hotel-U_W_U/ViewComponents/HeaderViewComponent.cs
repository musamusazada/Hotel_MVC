using Hotel_U_W_U.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_U_W_U.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private AppDbContext _context;

        public HeaderViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var settings = await _context.DefSettings.FirstOrDefaultAsync();

            return View(settings);
        }
    }
}
