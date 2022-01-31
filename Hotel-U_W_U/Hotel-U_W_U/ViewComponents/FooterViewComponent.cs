using Hotel_U_W_U.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Hotel_U_W_U.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private AppDbContext _context;

        public FooterViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            var setting = await _context.DefSettings.FirstOrDefaultAsync();
            return View(setting);
        }
    }
}
