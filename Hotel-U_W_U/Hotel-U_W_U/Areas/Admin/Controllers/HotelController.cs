using Hotel_U_W_U.Constants;
using Hotel_U_W_U.DAL;
using Hotel_U_W_U.Models.Entities;
using Hotel_U_W_U.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Hotel_U_W_U.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "admin,mod,hotel")]
    public class HotelController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public HotelController(AppDbContext context, UserManager<User> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<IActionResult> Index()
        {
            var user = await UserUtil.GetAuthUserFromHttpContext(_httpContextAccessor, _context);
            var currentUser = await _context.Users.FirstOrDefaultAsync(u => u.Id == user.Id);
            if (currentUser.hasHotel)
            {
                var hotel = await _context.hotels.FirstOrDefaultAsync(h => h.userID == user.Id);
                return View(hotel);
            }

            return RedirectToAction(nameof(CreateHotel));




        }
        public async Task<IActionResult> CreateHotel()
        {
            var user = await UserUtil.GetAuthUserFromHttpContext(_httpContextAccessor, _context);
            var currentUser = await _context.Users.FirstOrDefaultAsync(u => u.Id == user.Id);

            if (currentUser.hasHotel)
            {
                return RedirectToAction(nameof(Index));

            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateHotel(Hotel model)
        {
            var user = await UserUtil.GetAuthUserFromHttpContext(_httpContextAccessor, _context);

            var currentUser = await _context.Users.FirstOrDefaultAsync(u => u.Id == user.Id);


            model.img = FileUtil.CreateFile(FileConstants.imagePath, model.file);

            Hotel hotel = new Hotel
            {
                name = model.name,
                desc = model.desc,
                img = model.img,
                userID = user.Id,
                user = model.user,
            };

            await _context.hotels.AddAsync(hotel);
            currentUser.hasHotel = true;
            user.hasHotel = true;
            _context.Update(user);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
