using Hotel_U_W_U.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hotel_U_W_U.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "admin,mod,hotel")]
    public class DashboardController : Controller
    {
        private readonly UserManager<User> _userManager;
        public DashboardController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }



        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            return View(currentUser);
        }
        [Area("Admin")]
        [Authorize(Roles = "admin,mod,hotel")]
        public async Task<IActionResult> Profile()
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            return View(currentUser);
        }
    }
}
